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

namespace YZXDMS.Views.Master
{
    public partial class AssignCarView : DevExpress.XtraEditors.XtraUserControl
    {
        public AssignCarView()
        {
            InitializeComponent();
            //Mybug 后期修改为某段时间内的信息展示，防止数据量过多。
            //this.gridControl1.DataSource = Data.CurrentDB.GetInstance().DBSvc.GetWaitDetections();
            //this.gridControl2.DataSource = Data.CurrentDB.GetInstance().DBSvc.GetWaitDetectionsByStatus(1, 1);

        }

        /// <summary>
        /// 将待检车辆压如当前检测队列中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
