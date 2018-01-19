using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        public Form1()
        {
            InitializeComponent();
            Init();
            dtTimer = new System.Threading.Timer(x => UpdateDateTime(), null, 2000, 1000);
            //this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
        }

        void Init()
        {
            List<MenuGroup> menuGroups = new List<MenuGroup>();
            List<MenuItem> menuItems = new List<MenuItem>();

            menuGroups.Add(new MenuGroup()
            {
                Name = "设备设置",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "串口设置", View = new SettingPortView() },
                new MenuItem() { Name = "模块设置", View = new SettingDetectView() },
                new MenuItem() { Name = "工位设置", View = new SetStationView() }
            }
            });

            menuGroups.Add(new MenuGroup()
            {
                Name = "主控",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "主控检测", View = null },
                new MenuItem() { Name = "待检车辆", View = new Views.Master.AssignCarView() },
                new MenuItem() { Name = "车籍信息", View = null },
                new MenuItem() { Name = "信息查询", View = new Views.Master.QueryCarInfoView() }
            }
            });

            menuGroups.Add(new MenuGroup()
            {
                Name = "参数设置",
                MenuItems = new List<MenuItem>() {
                new MenuItem() { Name = "基本参数", View = null },
                new MenuItem() { Name = "时间参数", View = null }
            }
            });

            menuItems.Add(new MenuItem() { Name = "生成车辆", View = new XtraUserControl1() });
            menuItems.Add(new MenuItem() { Name = "测试1", View = new XtraUserControl1() });
            menuItems.Add(new MenuItem() { Name = "测试2", View = new UserControl1() });
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
            foreach (var item in menuItems)
            {
                DevExpress.XtraBars.Navigation.NavigationPage navPageTemp = new DevExpress.XtraBars.Navigation.NavigationPage();
                navPageTemp.Name = "";
                navPageTemp.Caption = item.Name;
                if (item.View != null)
                {
                    navPageTemp.Controls.Add(item.View);
                    item.View.Dock = DockStyle.Fill;
                    item.View.Location = new System.Drawing.Point(0, 0);
                }
                //this.xtraUserControl11.TabIndex = 0;

                navFrame.Controls.Add(navPageTemp);
                navFrame.Pages.Add(navPageTemp);

                DevExpress.XtraNavBar.NavBarItem navbarTemp = new DevExpress.XtraNavBar.NavBarItem() { Caption = item.Name };
                navbarTemp.LinkClicked += (s, e) =>
                {
                    //Mybug 最好改为点击命中后实例化view
                    navFrame.SelectedPage = (DevExpress.XtraBars.Navigation.INavigationPage)navFrame.Pages.SingleOrDefault(x => x.Caption == item.Name);
                };
                barGroup.ItemLinks.Add(navbarTemp);
            }
        }


        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Console.WriteLine(((DevExpress.XtraNavBar.NavElement)sender).Caption);
            navigationFrame1.SelectedPageIndex = 2;
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
