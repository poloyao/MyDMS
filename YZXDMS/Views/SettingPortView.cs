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
    public partial class SettingPortView : System.Windows.Forms.UserControl
    {
        public virtual ObservableCollection<PortConfig> Items { get; set; }
        public SettingPortView()
        {
            InitializeComponent();

            tileView1.FocusedRowHandle = 2;
            UpdateItems();
        }
        /// <summary>
        /// 更新列表信息
        /// </summary>
        private void UpdateItems()
        {
            var query = Data.SQLiteHelper.GetPortItems();
            Items = new ObservableCollection<PortConfig>(query);
            gridControl1.DataSource = Items;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            (new Views.PortView()).ShowDialog();
            UpdateItems();
        }



        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
