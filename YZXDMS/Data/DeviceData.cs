using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.IService;

namespace YZXDMS.Data
{
    /// <summary>
    /// 设备数据
    /// </summary>
    public class DeviceData
    {
        List<IDevice> DeviceList = new List<IDevice>();

        private static readonly DeviceData instance = new DeviceData();

        public static DeviceData GetInstance()
        {
            return instance;
        }

        private DeviceData()
        {
            DeviceList.Add(new TestLatticeScreenDevice());
            DeviceList.Add(new TestSpeedDevice());
        }

        /// <summary>
        /// 获取设备清单
        /// </summary>
        /// <returns></returns>
        public List<IDevice> GetDevices()
        {
            return DeviceList;
        }

        /// <summary>
        /// 初始化所有设备
        /// </summary>
        public List<OperateResult> InitDeviceAll()
        {
            List<OperateResult> resultList = new List<OperateResult>();
            foreach (var item in DeviceList)
            {
                resultList.Add(item.InitDevice());
            }
            return resultList;
        }

        /// <summary>
        /// 初始化指定设备
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public OperateResult InitDevice(IDevice device)
        {
            var result = device.InitDevice();
            Helper.NLogHelper.log.Info($"{device.GetDeviceName()} 初始化 【{ result.Result}】");
            return result;
        }


        
    }

    public class TestLatticeScreenDevice : ILatticeScreenDevice
    {
        public string GetCurrentMessage()
        {
            throw new NotImplementedException();
        }

        public string GetDeviceName()
        {
            return "TestLatticeScreenDevice";
        }

        public OperateResult InitDevice()
        {
            return new OperateResult(this.GetType()) { Result = true };
        }

        public OperateResult SetMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void SetPort(SerialPort port)
        {
            throw new NotImplementedException();
        }
    }

    public class TestSpeedDevice : ISpeedDevice
    {
        public string GetDeviceName()
        {
            return "TestSpeedDevice";
        }

        public OperateResult InitDevice()
        {
            return new OperateResult(this.GetType()) { Result = true };
        }

        public OperateResult Reset()
        {
            throw new NotImplementedException();
        }

        public void SetLinkDevices(List<IDevice> linkDevices)
        {
            throw new NotImplementedException();
        }

        public void SetPort(SerialPort port)
        {
            throw new NotImplementedException();
        }

        public Task<OperateResult> Start(object carInfo)
        {
            throw new NotImplementedException();
        }

        public OperateResult Stop()
        {
            throw new NotImplementedException();
        }
    }
}
