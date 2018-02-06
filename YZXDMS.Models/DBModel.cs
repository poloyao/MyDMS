using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Models
{

    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }

        public string Account { get; set; }
        public string PWD { get; set; }
        public string Title { get; set; }
    }


    [Table("waitdetection")]
    public class WaitDetection
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "车辆信息ID")]
        public int CarInfoId { get; set; }
        [Display(Name = "检验流水号")]
        public string jylsh { get; set; }
        [Display(Name = "检测线号")]
        public Nullable<int> LineID { get; set; }
        [Display(Name = "状态")]
        public int Status { get; set; }
        [Display(Name = "操作时间")]
        public System.DateTime UDP { get; set; }
    }

    static class ResultImgHelper
    {
        public const string CellMergingImagesPath = "pack://application:,,,/YZXDMS;component/Img/Result/";
    }
    /// <summary>
    /// 检测结果状态
    /// </summary>
    public enum DetectResultStatus
    {
        /// <summary>
        /// 默认待检
        /// </summary>       
        //[Image(ResultImgHelper.CellMergingImagesPath + "Qualified" + ".png")]
        Wait = 0,
        /// <summary>
        /// 合格 O
        /// </summary>
        [Image(ResultImgHelper.CellMergingImagesPath + "Qualified" + ".png")]
        Qualified,
        /// <summary>
        /// 不合格 X
        /// </summary>
        [Image(ResultImgHelper.CellMergingImagesPath + "Unqualified" + ".png")]
        Unqualified,
        /// <summary>
        /// 未检 -
        /// </summary>
        [Image(ResultImgHelper.CellMergingImagesPath + "NotChecked" + ".png")]
        NotChecked,
    }

    /// <summary>
    /// 检测结果
    /// </summary>
    public class DetectResult
    {
        [Display(AutoGenerateField = false)]
        public string CarID { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        [Display(Name = "流水号")]
        public string SerialData { get; set; }

        /// <summary>
        /// 最终结果
        /// </summary>
        [Display(Name = "最终结果")]
        public bool Final { get; set; }


        /// <summary>
        /// 外检
        /// </summary>
        [Display(Name = "外检")]
        public DetectResultStatus Shape { get; set; }
        /// <summary>
        /// 侧滑
        /// </summary>
        [Display(Name = "侧滑")]
        public DetectResultStatus SideSlide { get; set; }
        /// <summary>
        /// 速度
        /// </summary>
        [Display(Name = "速度")]
        public DetectResultStatus Speed { get; set; }
        /// <summary>
        /// 灯光
        /// </summary>
        [Display(Name = "灯光")]
        public DetectResultStatus Light { get; set; }
        /// <summary>
        /// 制动
        /// </summary>
        [Display(Name = "制动")]
        public DetectResultStatus Brake { get; set; }
        /// <summary>
        /// 称重
        /// </summary>
        [Display(Name = "称重")]
        public DetectResultStatus Weigh { get; set; }
        /// <summary>
        /// 底盘
        /// </summary>
        [Display(Name = "底盘")]
        public DetectResultStatus Bottom { get; set; }
        /// <summary>
        /// 地盘间隙
        /// </summary>
        [Display(Name = "地盘间隙")]
        public DetectResultStatus BoottomInterval { get; set; }
        /// <summary>
        /// 声级计
        /// </summary>
        [Display(Name = "声级计")]
        public DetectResultStatus SoundLevel { get; set; }
        /// <summary>
        /// 功率
        /// </summary>
        [Display(Name = "功率")]
        public DetectResultStatus Power { get; set; }
        /// <summary>
        /// 油耗
        /// </summary>
        [Display(Name = "油耗")]
        public DetectResultStatus FuelConsumption { get; set; }
        /// <summary>
        /// 尾气
        /// </summary>
        [Display(Name = "尾气")]
        public DetectResultStatus Exhaust { get; set; }
        /// <summary>
        /// 探平衡仪
        /// </summary>
        [Display(Name = "探平衡仪")]
        public DetectResultStatus Balancer { get; set; }
    }

}
