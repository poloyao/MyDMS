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

namespace YZXDMS.Views
{
    public partial class SetStationView : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// 拖拽数据的原始列表
        /// </summary>
        ListView tagLV;
        /// <summary>
        /// 工位列表组.
        /// listView6 对应的是0号
        /// </summary>
        List<string> ds = new List<string>() { "listView6", "listView1", "listView2", "listView3", "listView4", "listView5" };
        public SetStationView()
        {
            InitializeComponent();
            InitData();

        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            var queryDetectors = Data.SQLiteHelper.GetDetectorItems();
            int stationNum = 0;
            foreach (var item in ds)
            {
                var queryLists = this.Controls.Find(item, true);
                if (queryLists != null && queryLists.Count() > 0)
                {
                    var DetectorDatas = queryDetectors.Where(x => x.StationValue == stationNum).ToList();
                    stationNum++;
                    DetectorDatas.ForEach(x =>
                    {
                        ListViewItem li = new ListViewItem();
                        li.SubItems[0].Text = x.DetectorName;
                        ((ListView)queryLists[0]).Items.Add(li);
                    });

                    ((ListView)queryLists[0]).DragDrop += (s, e) =>
                    {
                        ListView.SelectedListViewItemCollection items = e.Data.GetData("mydata") as ListView.SelectedListViewItemCollection;
                        foreach (ListViewItem lvi in items)
                        {
                            ((ListView)(s)).Items.Add(lvi.Text);
                            tagLV.Items.Remove(tagLV.SelectedItems[0]);
                        }
                        SaveData();
                    };
                    ((ListView)queryLists[0]).ItemDrag += (s, e) =>
                    {
                        tagLV = s as ListView;
                        tagLV.DoDragDrop(new DataObject("mydata", tagLV.SelectedItems), DragDropEffects.Move);
                    };
                    ((ListView)queryLists[0]).DragEnter += (s, e) =>
                    {
                        if (e.Data.GetDataPresent("mydata"))
                            e.Effect = DragDropEffects.Move;
                        else
                            e.Effect = DragDropEffects.None;
                    };

                    Console.WriteLine("添加完成");
                }
            }
        }


        /// <summary>
        /// 保存移动后的数据
        /// </summary>
        void SaveData()
        {
            int stationNum = 0;
            foreach (var item in ds)
            {
                var queryLists = this.Controls.Find(item, true);
                if (queryLists != null && queryLists.Count() > 0)
                {
                    var datas = ((ListView)queryLists[0]).Items;
                    //var query = Data.SQLiteHelper.GetDetectorItems();
                    List<string> detectorsStr = new List<string>();
                    foreach (ListViewItem lvi in datas)
                    {
                        detectorsStr.Add(lvi.SubItems[0].Text);
                    }
                    var resutl = Data.SQLiteHelper.SetDetectorsToStation(detectorsStr, stationNum);
                    if (resutl == string.Empty)
                    {
                        //ok
                    }
                    else
                    {
                        MessageBox.Show(resutl);
                        break;
                    }
                }
                stationNum++;
            }
        }
    }
}
