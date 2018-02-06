using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZXDMS.Views;

namespace YZXDMS
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// 静态计时器
        /// </summary>
        static System.Threading.Timer dtTimer;
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            
            sw.Start();
            //检测数据库是否可连接
            var svc = Data.CurrentDB.GetInstance();
            if (!svc.DBSvc.DBExists())
            {

                MessageBox.Show($"远程数据库无法访问，请检查连接和数据库是否已启动。耗时：{sw.Elapsed.ToString()}");
                sw.Restart();
            }

            Init();
            dtTimer = new System.Threading.Timer(x => UpdateDateTime(), null, 2000, 1000);
            //this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            sw.Stop();
            //MessageBox.Show(sw.Elapsed.ToString());
            Helper.NLogHelper.log.Debug(sw.Elapsed.ToString());
        }

        void Init()
        {       
            List<MenuGroup> menuGroups = new List<MenuGroup>();
            List<MenuItem> menuItems = new List<MenuItem>();

            menuGroups.Add(new MenuGroup()
            {
                Name = "设备设置",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "串口设置", ControlType = typeof(SettingPortView)},
                new MenuItem() { Name = "模块设置", ControlType = typeof(SettingDetectView) },
                new MenuItem() { Name = "工位设置", ControlType = typeof(SetStationView) }
            }
            });

            menuGroups.Add(new MenuGroup()
            {
                Name = "主控",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "主控检测", ControlType = typeof(Views.Master.MasterView)  },
                new MenuItem() { Name = "待检车辆", ControlType = typeof(Views.Master.AssignCarView) },
                new MenuItem() { Name = "车籍信息", ControlType = typeof(Views.Master.CarInfoView)  },
                new MenuItem() { Name = "信息查询", ControlType = typeof(Views.Master.QueryCarInfoView) }
            }
            });

            menuGroups.Add(new MenuGroup()
            {
                Name = "参数设置",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "基本参数",ControlType = typeof(Views.Settings.SettingBaseView) },
                new MenuItem() { Name = "时间参数",ControlType = typeof(Views.Settings.SettingTimeView) }
            }
            });

            menuItems.Add(new MenuItem() { Name = "生成车辆", ControlType = typeof(XtraUserControl1) });
            menuItems.Add(new MenuItem() { Name = "测试1", ControlType = typeof(XtraUserControl1) });
            menuItems.Add(new MenuItem() { Name = "测试2", ControlType = typeof(UserControl1) });
            menuGroups.Add(new MenuGroup() { Name = "测试组", MenuItems = menuItems });

            CreateMenuGroup(this.navBarControl1, this.navigationFrame1, menuGroups);
            
        }     

        /// <summary>
        /// 更新时间
        /// </summary>
        void UpdateDateTime()
        {
            try
            {
                if (this.IsHandleCreated || IsDisposed)
                    this.Invoke(new Action(() => { this.CurrentTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss"); }));
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
         }

        /// <summary>
        /// 闯将菜单分组
        /// </summary>
        /// <param name="navControl"></param>
        /// <param name="navFrame"></param>
        /// <param name="menuGroups"></param>
        void CreateMenuGroup(DevExpress.XtraNavBar.NavBarControl navControl, DevExpress.XtraBars.Navigation.NavigationFrame navFrame, List<MenuGroup> menuGroups)
        {
            DevExpress.XtraGrid.Views.Tile.TileView aaa = new DevExpress.XtraGrid.Views.Tile.TileView();
            foreach (var item in menuGroups)
            {
                //Mybug 需要先检查是否已存在同名组，无则生成

                var navBarGroupTemp = new DevExpress.XtraNavBar.NavBarGroup();
                navBarGroupTemp.Caption = item.Name;
                navBarGroupTemp.Expanded = true;
                navControl.Groups.Add(navBarGroupTemp);
                CreateMenu(navFrame, navBarGroupTemp, item.MenuItems);
            }
        }

        /// <summary>
        /// 创建菜单
        /// </summary>
        /// <param name="navFrame"></param>
        /// <param name="barGroup"></param>
        /// <param name="menuItems"></param>
        void CreateMenu(DevExpress.XtraBars.Navigation.NavigationFrame navFrame, DevExpress.XtraNavBar.NavBarGroup barGroup, List<MenuItem> menuItems)
        {
            Stopwatch sw = new Stopwatch();
            foreach (var item in menuItems)
            {
                DevExpress.XtraBars.Navigation.NavigationPage navPageTemp = new DevExpress.XtraBars.Navigation.NavigationPage();
                navPageTemp.Name = "";
                navPageTemp.Caption = item.Name;

                navFrame.Controls.Add(navPageTemp);
                navFrame.Pages.Add(navPageTemp);

                DevExpress.XtraNavBar.NavBarItem navbarTemp = new DevExpress.XtraNavBar.NavBarItem() { Caption = item.Name };
                
                navbarTemp.LinkClicked += (s, e) =>
                {
                    sw.Restart();                  
                    //初次点击实例化
                    if (item.ControlType != null)
                    {
                        if (item.View == null)
                        {
                            UserControl intance = (UserControl)item.ControlType.Assembly.CreateInstance(item.ControlType.FullName);
                            item.View = intance;
                            navPageTemp.Controls.Add(item.View);
                            item.View.Dock = DockStyle.Fill;
                            item.View.Location = new System.Drawing.Point(0, 0);
                            System.Diagnostics.Debug.WriteLine($"临时生成了view:{item.Name}");
                        }
                    }

                    navFrame.SelectedPage = (DevExpress.XtraBars.Navigation.INavigationPage)navFrame.Pages.SingleOrDefault(x => x.Caption == item.Name);
                    sw.Stop();
                    System.Diagnostics.Debug.WriteLine($"创建或打开view:{item.Name}耗时：{sw.Elapsed}");
                };
                barGroup.ItemLinks.Add(navbarTemp);
            }
        }


        UserControl aajjjj<T>() where T:UserControl
        {
            return default(T);
        }


        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Console.WriteLine(((DevExpress.XtraNavBar.NavElement)sender).Caption);
            navigationFrame1.SelectedPageIndex = 2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            //this.Dispose();
            //Application.Exit();
        }
    }

    public class MenuItem
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Name { get; set; }
        ///// <summary>
        ///// 所属组
        ///// </summary>
        //public string Group { get; set; }
        /// <summary>
        /// 关联视图
        /// </summary>
        public UserControl View { get; set; }
        /// <summary>
        /// 视图组件类型
        /// </summary>
        public Type ControlType { get; set; }
    }

    public class MenuGroup
    {
        /// <summary>
        /// 组名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 组员
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }
    }
}
