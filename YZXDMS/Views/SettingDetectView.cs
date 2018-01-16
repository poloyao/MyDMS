using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.ObjectModel;
using YZXDMS.Models;

namespace YZXDMS.Views
{
    public partial class SettingDetectView : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// 检测模块列表
        /// </summary>
        public virtual ObservableCollection<DetectorModel> Items { get; set; }
        /// <summary>
        /// 当前的检测模块的关联辅助信息
        /// </summary>
        public virtual ObservableCollection<PortConfig> CurrentPortItems { get; set; } = new ObservableCollection<PortConfig>();

        public SettingDetectView()
        {
            InitializeComponent();

            var query = Data.SQLiteHelper.GetDetectorItems();
            Items = new ObservableCollection<DetectorModel>(query);

            this.gridControl1.DataSource = Items;
            //tileView1_FocusedRowChanged
            tileView1.FocusedRowHandle = 0;
            this.LCG_detector.Text = $"【{Items[0].DetectorName}】模块";
            SetDisplayDetector(Items[0]);

            this.gridControl2.DataSource = CurrentPortItems;
            
        }

        /// <summary>
        /// 设置显示内容
        /// </summary>
        /// <param name="item"></param>
        void SetDisplayDetector(DetectorModel item)
        {
            //清空
            {
                this.ed_DetectorName.Text = "";
                this.ed_Parity.Text = "";
                this.ed_PortName.Text = "";
                this.ed_StopBits.Text = "";
                this.ed_BaudRate.Text = "";
                this.ed_DataBits.Text = "";

                CurrentPortItems.Clear();
            }

            this.ed_DetectorName.Text = item.DetectorName;
            //判断有无串口id，有则获取并显示
            if (item.PortId > 0)
            {
                var portInfo = Data.SQLiteHelper.GetPortItemsByID(item.PortId);
                if (portInfo.Id > 0)
                {
                    this.ed_Parity.Text = portInfo.Parity.ToString();
                    this.ed_PortName.Text = portInfo.PortName.ToString();
                    this.ed_StopBits.Text = portInfo.StopBits.ToString();
                    this.ed_BaudRate.Text = portInfo.BaudRate.ToString();
                    this.ed_DataBits.Text = portInfo.DataBits.ToString();
                }
            }
            //获取此项目的辅助列表
            var assistList = Data.SQLiteHelper.GetAssistItemsByDetectID(item.Id);
            assistList.ForEach(x =>
            {
                var queryPort = Data.SQLiteHelper.GetPortItemsByID(x.PortId);
                CurrentPortItems.Add(queryPort);
            });

        }
        

        /// <summary>
        /// 添加新模块信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDetector_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除模块信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDetector_Click(object sender, EventArgs e)
        {

        }

        private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var items = (((DevExpress.XtraGrid.Views.Base.BaseView)sender).DataSource as ObservableCollection<DetectorModel>);
            var item = items[e.FocusedRowHandle];
            Console.WriteLine(item.DetectorName);
            Console.WriteLine("tileView1_FocusedRowChanged: " + e.FocusedRowHandle);
            this.LCG_detector.Text = $"【{item.DetectorName}】模块";

            SetDisplayDetector(item);

        }

        private void tileView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Console.WriteLine("SelectionChanged");
        }
    }
}
