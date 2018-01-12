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

        public virtual ObservableCollection<DetectorModel> Items { get; set; }
        public SettingDetectView()
        {
            InitializeComponent();

            //tileView1.Appearance.ItemFocused.BackColor = Color.FromArgb(40, Color.FromArgb(248, 124, 50));
            //tileView1.Appearance.ItemHovered.BackColor = Color.FromArgb(40, Color.FromArgb(248, 124, 50));
            tileView1.FocusedRowHandle = 2;
            

            var query = Data.SQLiteHelper.GetDetectorItems();
            Items = new ObservableCollection<DetectorModel>(query);

            this.gridControl1.DataSource = Items;

        }



    }
}
