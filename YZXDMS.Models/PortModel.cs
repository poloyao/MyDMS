﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Models
{
    /// <summary>
    /// 串口端口
    /// </summary>
    public enum PortIndex
    {
        COM1,
        COM2,
        COM3,
        COM4,
        COM5,
        COM6,
        COM7,
        COM8,
        COM9,
        COM10,
        COM11,
        COM12,
        COM13,
        COM14,
        COM15,
        COM16,
        COM17,
        COM18,
        COM19,
        COM20,
        COM21,
        COM22,
        COM23,
        COM24,
        COM25,
        COM26,
        COM27,
        COM28,
        COM29,
        COM30,
        COM31,
        COM32,

    }
    


    /// <summary>
    /// 辅助设备类型
    /// </summary>
    public enum AssistDeviceType
    {
        灯屏设备 = 101,
        光电设备 = 102,
        录像设备 = 103,
        拍照设备 = 104,
    }

    /// <summary>
    /// 检测类型，顺序必须同DeviceType一致
    /// </summary>
    public enum DetectionType
    {
        /// <summary>
        /// Shape
        /// </summary>
        外检 = 0,
        /// <summary>
        /// SideSlide
        /// </summary>
        侧滑,
        /// <summary>
        ///  Speed
        /// </summary>
        速度,
        /// <summary>
        /// Light
        /// </summary>
        灯光,
        /// <summary>
        /// Brake
        /// </summary>
        制动,
        /// <summary>
        /// Weigh
        /// </summary>
        称重,
        /// <summary>
        ///  Bottom
        /// </summary>
        底盘,
        /// <summary>
        /// BoottomInterval
        /// </summary>
        底盘间隙,
        /// <summary>
        /// SoundLevel
        /// </summary>
        声级计,
        /// <summary>
        /// Power
        /// </summary>
        功率,
        /// <summary>
        /// FuelConsumption
        /// </summary>
        油耗,
        /// <summary>
        /// Exhaust
        /// </summary>
        尾气,
        /// <summary>
        ///  Balance
        /// </summary>
        探平衡仪,
    }


    /// <summary>
    /// 设备性质
    /// </summary>
    public enum DeviceProperty
    {
        /// <summary>
        /// 辅助设备
        /// </summary>
        辅助设备,
        /// <summary>
        /// 检测设备
        /// </summary>
        检测设备
    }

    /// <summary>
    /// 设备类型,
    /// 100之前为主设备，100之后未辅助设备.
    ///  灯屏设备 = 101,
    ///  光电设备 = 102,
    ///  录像设备 = 103,
    ///  拍照设备 = 104,
    /// </summary>
    //[Flags]
    public enum DeviceType
    {
        /// <summary>
        /// Shape
        /// </summary>
        外检 = 0,
        /// <summary>
        /// SideSlide
        /// </summary>
        侧滑,
        /// <summary>
        ///  Speed
        /// </summary>
        速度,
        /// <summary>
        /// Light
        /// </summary>
        灯光,
        /// <summary>
        /// Brake
        /// </summary>
        制动,
        /// <summary>
        /// Weigh
        /// </summary>
        称重,
        /// <summary>
        ///  Bottom
        /// </summary>
        底盘,
        /// <summary>
        /// BoottomInterval
        /// </summary>
        底盘间隙,
        /// <summary>
        /// SoundLevel
        /// </summary>
        声级计,
        /// <summary>
        /// Power
        /// </summary>
        功率,
        /// <summary>
        /// FuelConsumption
        /// </summary>
        油耗,
        /// <summary>
        /// Exhaust
        /// </summary>
        尾气,
        /// <summary>
        ///  Balance
        /// </summary>
        探平衡仪,

        灯屏设备 = 101,
        光电设备 = 102,
        录像设备 = 103,
        拍照设备 = 104,
    }

    /// <summary>
    /// 串口配置信息
    /// </summary>
    [Table("PortConfig")]
    public class PortConfig : ICloneable
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// 串口名称
        /// </summary>
        [Display(Name = "串口名称")]
        public virtual string Name { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        [Display(Name = "端口")]
        public PortIndex PortName { get; set; } = PortIndex.COM1;
        /// <summary>
        /// 波特率
        /// </summary>
        [Display(Name = "波特率")]
        public int BaudRate { get; set; } = 9600;
        /// <summary>
        /// 数据位
        /// </summary>
        [Display(Name = "数据位")]
        public int DataBits { get; set; } = 8;
        /// <summary>
        /// 奇偶校验
        /// </summary>
        [Display(Name = "奇偶校验")]
        public Parity Parity { get; set; } = Parity.None;
        /// <summary>
        /// 停止位
        /// </summary>
        [Display(Name = "停止位")]
        public StopBits StopBits { get; set; } = StopBits.One;

        ///// <summary>
        ///// 通道数量,1到8
        ///// </summary>
        //[Display(Name = "通道数量")]

        //public int RouteTotal { get; set; } = 1;
        ///// <summary>
        ///// 协议厂家
        ///// </summary>
        //[Display(Name = "协议厂家")]
        //public String Protocol { get; set; }

        ///// <summary>
        ///// 设备类型
        ///// </summary>
        //[Display(Name = "设备类型")]
        //public DeviceType DeviceType { get; set; }

        public object Clone()
        {
            var result = new PortConfig();
            result.Id = this.Id;
            result.Name = this.Name;
            result.PortName = this.PortName;
            result.BaudRate = this.BaudRate;
            result.DataBits = this.DataBits;
            result.Parity = this.Parity;
            result.StopBits = this.StopBits;
            //result.Protocol = this.Protocol;
            //result.DeviceType = this.DeviceType;
            //result.RouteTotal = this.RouteTotal;

            return result;
        }

        public static PortConfig Create()
        {
            var result = new PortConfig();
            result.Name = "默认";
            result.PortName = PortIndex.COM1;
            result.BaudRate = 9600;
            result.DataBits = 8;
            result.Parity = Parity.None;
            result.StopBits = StopBits.One;
            //result.Protocol = "无";
            //result.DeviceType = DeviceType.光电设备;

            //result.RouteTotal = 1;

            return result;
        }
    }

    /// <summary>
    /// 检测项目配置信息
    /// </summary>
    [Table("Detector")]
    public class DetectorModel
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 检测模块名称
        /// </summary>
        [Display(Name = "检测模块名称")]
        public string DetectorName { get; set; }
        /// <summary>
        /// 检测模块类型
        /// </summary>
        [Display(Name = "检测模块类型")]
        public DetectionType DetectorType { get; set; }
        /// <summary>
        /// 检测模块串口
        /// </summary>
        [Display(Name = "检测模块串口")]
        public long PortId { get; set; }
        /// <summary>
        /// 工位编号
        /// </summary>
        [Display(Name = "工位编号")]
        public int StationValue { get; set; }

    }



    /// <summary>
    /// 检测项目辅助设备
    /// </summary>
    [Table("Assist")]
    public class AssistModel
    {
        [Key]
        public long Id { get; set; }

        public long DetectorId { get; set; }

        public long PortId { get; set; }
        /// <summary>
        /// 辅助类型
        /// </summary>
        public AssistDeviceType AssistType { get; set; }

        /// <summary>
        /// 调用线路
        /// </summary>
        [Display(Name = "调用线路")]
        public int Route { get; set; }
        /// <summary>
        /// 此辅助项目同类型的排序
        /// </summary>
        [Display(Name = "序号")]
        public int Index { get; set; }
    }

    /// <summary>
    /// 用于显示的辅助
    /// </summary>
    public class AssistDisplayModel
    {
        public AssistModel Assist { get; set; }
        public PortConfig Port { get; set; }
    }



    /// <summary>
    /// 工位配置
    /// </summary>
    [Table("Station")]
    public class StationModel
    {
        [Key]
        public long Id { get; set; }
        public string StationName { get; set; }
        public int Value { get; set; }
        /// <summary>
        /// 是否自动检测 默认true
        /// </summary>
        public bool IsAutoTest { get; set; } = true;

    }




    /// <summary>
    /// 串口实例和配置
    /// </summary>
    public class PortWithConfig
    {
        /// <summary>
        /// 串口信息
        /// </summary>
        public SerialPort Port { get; set; }
        /// <summary>
        /// 串口配置信息
        /// </summary>
        public PortConfig Config { get; set; }
    }



    ///// <summary>
    ///// 启动模式
    ///// </summary>
    //public enum StartMode
    //{
    //    保持开启,
    //    即用即关
    //}



    public class DBSetting
    {
        [Key]
        public long ID { get; set; }

        public int DBType { get; set; }

        public string IP { get; set; }

        public string Port { get; set; }

        public string PWD { get; set; }

        public int Status { get; set; }
    }



}
