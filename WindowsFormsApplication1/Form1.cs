using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<DisplayItem> list = new List<DisplayItem>();
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 1 });

            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 2 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 2 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 2 });
            list.Add(new DisplayItem() { Name = "Name", Sex = "Sex", Des = "des", status = 2 });

            this.gridControl1.DataSource = list;


            this.tileView1.ItemCustomize += TileView1_ItemCustomize;
            this.tileView1.ItemDrop += TileView1_ItemDrop;

        }

        private void TileView1_ItemDrop(object sender, DevExpress.XtraGrid.Views.Tile.ItemDropEventArgs e)
        {
            var newStatus = e.GroupColumnValue.ToString();
            var prevStatus = e.PrevGroupColumnValue.ToString();
            if (!prevStatus.Equals(newStatus))
            {
                tileView1.BeginDataUpdate();
                tileView1.EndDataUpdate();
            }
        }

        private void TileView1_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            DisplayItem di = tileView1.GetRow(e.RowHandle) as DisplayItem;
            //e.Item.AppearanceItem.Normal.BackColor = Color.LightGray;
            //e.Item.AppearanceItem.Normal.ForeColor = Color.DarkGray;
            if (di == null)
                return;
            if (IsEmptyItem(e.RowHandle))
            {
                e.Item["Name"].Text = "Add a card...";
                e.Item.AppearanceItem.Normal.BackColor = Color.LightGray;
                e.Item.AppearanceItem.Normal.ForeColor = Color.DarkGray;
            }
           
            


        }

        bool IsEmptyItem(int rowHandle)
        {
            var row = tileView1.GetRow(rowHandle);
            if (row == null) return false;
            return tileView1.GetRowCellValue(rowHandle, "Name").ToString() != "Name";
        }
    }


    public class DisplayItem
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Des { get; set; }
        public int status { get; set; }

    }
}
