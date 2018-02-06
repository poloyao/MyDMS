using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace YZXDMS.Views.Settings
{
    public partial class SettingBaseView : UserControl
    {
        public SettingBaseView()
        {
            InitializeComponent();


            


            List<SettingModel> settings = new List<SettingModel>();

            settings.Add(new SettingModel() { Group = "基础设置", Name = "最大工位数", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "大灯检测", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "工位控制板数", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "控制板最大通道数", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "汽车轴重下限值", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "摩托车轴重下限值", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "检测站编号", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "检测线代号", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "制动数据最小字节数", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "大型车灯高", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "小型车灯高", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "工位照片上传方式", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "照片重传次数", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "复检车重新称重", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "滚筒制动/轴重复合仪表", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "滚筒制动/轴重复合仪台", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "轴重台存在中间小板", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "存在平板制动", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "华燕制动台电机保护值", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "制动检测失败允许重检", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "低速三轮车前轮手刹检测取轮重", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "制动检测复位使用遥控器", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "多轴车有光电信号直接称重", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "华燕平板按曲线重新计算结果", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "明泉大灯使用灯高调节", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "灯光检测允许在线调整", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "大灯复检左右全部检测", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "摩托车左灯检测", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "正三轮摩托车后轮用摩托车设备检测", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "加载制动不合格允许再检一次", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "正三轮摩托车后轮用汽车后板", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "地盘检测结束码", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "大灯检测使用遥控", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "双灯检测不合格允许单灯检测", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "检验报告单套打", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "检验报告单打印", Type = SettingType.TEXT });
            settings.Add(new SettingModel() { Group = "基础设置", Name = "仪器设备检验表套打", Type = SettingType.TEXT });


            //for (int i = 1; i <= 17; i++)
            //{
            //    string caption = "Memo " + i;
            //    settings.Add(new SettingModel() { Group = "设置1", Name = caption, Type = SettingType.TEXT });
            //}

            //for (int i = 1; i <= 17; i++)
            //{
            //    string caption = "Memo " + i;
            //    settings.Add(new SettingModel() { Group = "设置2", Name = caption, Type = SettingType.TEXT });
            //}

            var settingGroups = settings.GroupBy(x => x.Group).ToList();
            

            foreach (var sgroup in settingGroups)
            {
                //LayoutControlGroup tempGroup = this.layoutControl1.AddGroup();
                //tempGroup.Text = sgroup.Key;

                var tg = SetGroup(sgroup.ToList());
                tg.Text = sgroup.Key;
                this.layoutControl1.AddGroup(tg);
            }

        }

        private LayoutControlGroup SetGroup( List<SettingModel> sgroup)
        {
            LayoutControlGroup tempGroup = new LayoutControlGroup();
            foreach (var item in sgroup)
            {
                switch (item.Type)
                {
                    case SettingType.TEXT:
                        Control con = new TextBox() { };
                        //con.Size = new Size(150, 80);
                        tempGroup.AddItem(item.Name, con);
                        break;
                    case SettingType.INT:
                        break;
                    case SettingType.DATE:
                        break;
                    case SettingType.CHECK:
                        break;
                    case SettingType.COMBOBOX:
                        break;
                    default:
                        break;
                }
            }
            tempGroup.BestFit();
            tempGroup.LayoutMode = LayoutMode.Table;

            return tempGroup;
        }
    }


    public class SettingModel
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public SettingType Type { get; set; }
        public object Attached { get; set; }
    }

    public enum SettingType
    {
        /// <summary>
        /// 文本
        /// </summary>
        TEXT = 0,
        /// <summary>
        /// 数字
        /// </summary>
        INT,
        /// <summary>
        /// 日期
        /// </summary>
        DATE,
        /// <summary>
        /// 单选
        /// </summary>
        CHECK,
        /// <summary>
        /// 选择
        /// </summary>
        COMBOBOX
    }
}
