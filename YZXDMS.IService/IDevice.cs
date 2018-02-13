using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.IService
{
    /// <summary>
    /// 设备接口
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// 获取设备名称
        /// </summary>
        /// <returns></returns>
        string GetDeviceName();

        /// <summary>
        /// 传入串口信息
        /// </summary>
        void SetPort(SerialPort port);
        

        /// <summary>
        /// 设备初始化
        /// </summary>
        /// <returns></returns>
        OperateResult InitDevice();

    }

    /// <summary>
    /// 灯屏设备接口
    /// </summary>
    public interface ILatticeScreenDevice:IDevice
    {
        /// <summary>
        /// 设置显示信息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        OperateResult SetMessage(string message);
        /// <summary>
        /// 获取当前显示信息
        /// </summary>
        /// <returns></returns>
        string GetCurrentMessage();
    }

    /// <summary>
    /// 速度设备
    /// </summary>
    public interface ISpeedDevice : IDevice
    {
        /// <summary>
        /// 设备复位
        /// </summary>
        /// <returns></returns>
        OperateResult Reset();

        /// <summary>
        /// 设备终止
        /// </summary>
        /// <returns></returns>
        OperateResult Stop();

        /// <summary>
        /// 设备启动开始检测 。
        /// 异步执行。
        /// 回传结果数据。
        /// 传入车辆信息，如号牌，型号，检测项目等，用于配置相应检测参数。
        /// </summary>
        /// <returns></returns>
        Task<OperateResult> Start(object carInfo);

        /// <summary>
        /// 设置关联设备
        /// </summary>
        void SetLinkDevices(List<IDevice> linkDevices);
        

    }




    public interface IProject
    {

    }

    /// <summary>
    /// 操作结果信息
    /// </summary>
    public class OperateResult
    {
        public OperateResult(Type type)
        {
            this.Type = type;
        }
        /// <summary>
        /// 调用者类型
        /// </summary>
        public Type Type { get; }
        /// <summary>
        /// 结果
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 挂载数据
        /// </summary>
        public object Data { get; set; }
    }

    public class TestLCD : ILatticeScreenDevice
    {
        
        public OperateResult InitDevice()
        {
            throw new NotImplementedException();
        }

        public string GetCurrentMessage()
        {
            throw new NotImplementedException();
        }        

        public OperateResult Reset()
        {
            throw new NotImplementedException();
        }

        public OperateResult SetMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void SetPort(SerialPort port)
        {
            throw new NotImplementedException();
        }

        public OperateResult Start()
        {
            throw new NotImplementedException();
        }

        public OperateResult Stop()
        {
            throw new NotImplementedException();
        }

        public string GetDeviceName()
        {
            throw new NotImplementedException();
        }
    }

    public class TestInterface
    {
        async void aaa()
        {
            ILatticeScreenDevice test = new TestLCD();

            test.SetPort(new SerialPort());
            test.InitDevice();
            //test.Start();
            test.SetMessage("message");
            test.GetCurrentMessage();

            ISpeedDevice speed = null;
            speed.SetPort(new SerialPort());
            speed.SetLinkDevices(new List<IDevice>());
            speed.InitDevice();
            await speed.Start(null);
        }        
    }
    
}


#region 显示演示



//class Program
//{
//    static void Main(string[] args)
//    {
//        Stopwatch sw = new Stopwatch();
//        //Console.Write("3333333333");
//        Console.WriteLine("111111111111111111");
//        sw.Start();
//        A a = new A(sw);
//        //var aa = a.Start();
//        //Console.WriteLine(aa);


//        //Task t1 = Task.Factory.StartNew(() =>
//        //{

//        //    Console.WriteLine("run t1:", +sw.ElapsedMilliseconds);
//        //    //var aa = a.Start();
//        //    //aa.Start();
//        //    //Console.WriteLine(aa.Result + " " + sw.ElapsedMilliseconds);

//        //    var aaa = a.TaskMethod();
//        //    Console.WriteLine(aaa + " " + sw.ElapsedMilliseconds);

//        //});


//        var aa = a.Start();
//        aa.Start();


//        System.Threading.Thread.Sleep(3000);

//        Console.WriteLine("222222222222222222" + " " + sw.ElapsedMilliseconds);



//        Console.WriteLine("333333333333333" + " " + sw.ElapsedMilliseconds);
//        //Console.WriteLine(t1.Status);

//        Console.WriteLine(aa.Result);

//        Console.ReadKey();
//    }
//}


//public class A
//{
//    Stopwatch sw = new Stopwatch();
//    public A(Stopwatch sw)
//    {
//        this.sw = sw;
//    }
//    public Task<string> Start()
//    {
//        return new Task<string>((() => TaskMethod()));
//    }

//    public string TaskMethod()
//    {
//        Console.WriteLine("run A " + sw.ElapsedMilliseconds);
//        System.Threading.Thread.Sleep(2000);
//        return "taskMethod " + sw.ElapsedMilliseconds;
//    }
//}


#endregion