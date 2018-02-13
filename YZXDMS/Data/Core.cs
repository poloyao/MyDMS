using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Data
{
    /// <summary>
    /// 在设备初始化后，实例化此核心控制
    /// </summary>
    public class Core
    {
        private static readonly Core instance = new Core();

        public static Core GetInstance()
        {
            return instance;
        }

        private Core()
        {
            //检测配置的所有串口状态

            //生成检测工位、顺序树


            //获取所有设备
            var devices = DeviceData.GetInstance().GetDevices();
            //初始化所有在线设备
            foreach (var item in devices)
            {
                var result = DeviceData.GetInstance().InitDevice(item);
            }            

            //获取遗留检测队列

            
        }

    }
}
