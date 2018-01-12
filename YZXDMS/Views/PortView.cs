using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YZXDMS.Models;
using System.IO.Ports;

namespace YZXDMS.Views
{
    public partial class PortView : DevExpress.XtraEditors.XtraForm
    {
        public PortView()
        {
            InitializeComponent();
            
            this.PortName.Properties.Items.AddRange(Enum.GetNames(typeof(PortIndex)));
            this.PortName.SelectedIndex = 0;
            this.DataBits.Properties.Items.AddRange(new List<int>() { 5, 6, 7, 8 });
            this.DataBits.SelectedItem = 8;
            this.Parity.Properties.Items.AddRange(Enum.GetNames(typeof(Parity)));
            this.Parity.SelectedIndex = 0;
            this.StopBits.Properties.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            this.StopBits.SelectedIndex = 0;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PortConfig port = new PortConfig();
            port.Name = this.Name_ed.Text;
            port.PortName = (PortIndex)Enum.Parse(typeof(PortIndex), this.PortName.SelectedItem.ToString());
            port.BaudRate = int.Parse(this.BaudRate.Text);
            port.DataBits = (int)this.DataBits.SelectedItem;
            port.Parity = (Parity)Enum.Parse(typeof(Parity), this.Parity.SelectedItem.ToString());
            port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.StopBits.SelectedItem.ToString());

            var result = Data.SQLiteHelper.SavePortInfo(port);
            if (result == string.Empty)
            {
                //ok
                return;
            }
            else
            {
                MessageBox.Show(result);
                return;
            }


        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}