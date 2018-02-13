using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZXDMS.Models;
using DevExpress.Data;
using System.Threading;
using System.Collections;

namespace YZXDMS.Views.Master
{
    public partial class MasterView : UserControl
    {
        public MasterView()
        {
            InitializeComponent();


            this.Load += MasterView_Load;
            
        }

        private void MasterView_Load(object sender, EventArgs e)
        {
           

            var  syncContext = SynchronizationContext.Current;
            chtr = new ChangeThead(syncContext);
            
            //..
            realTimeSource = CreateRealTimeSource();
            gridControl1.DataSource = realTimeSource;
            realTimeSource.DataSource = chtr.List;

            //MockData();
            dtTimerUp = new System.Threading.Timer(x => { chtr.Do(); }, null, 0, 2000);
        }

        RealTimeSource realTimeSource;
        ChangeThead chtr;

        List<DetectResult> data = new List<DetectResult>();

        System.Threading.Timer dtTimer;

        System.Threading.Timer dtTimerUp;


        private RealTimeSource CreateRealTimeSource()
        {
            RealTimeSource rts = new RealTimeSource();
            return rts;
        }

        #region 模拟


        /// <summary>
        /// 模拟数据
        /// </summary>
        private void MockData()
        {
            dtTimer = new System.Threading.Timer(x => { DDD(); }, null, 0, 1000);

        }

        private void DDD()
        {
            var collection = chtr.List as BindingList<DetectResult>;
            if (collection[0].Speed == DetectResultStatus.Wait)
                collection[0].Speed = DetectResultStatus.Qualified;
            else
                collection[0].Speed = DetectResultStatus.Wait;
            collection.ResetItem(0);

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "DDD");
        }

        #endregion

       

        /// <summary>
        /// 设备初始化.应为全局一次性的。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //获取设备清单
            //逐项进行初始化
            //反馈执行结果
            //疑问点，是否区分核心设备和非必要设备


            Data.Core.GetInstance();
        }

        /// <summary>
        /// 开始检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //初始化成功后方可执行
            //根据车辆队列和检测顺序逐一进行检测
            //项目间线程隔离，并发操作
            //后期加入插队逻辑
        }
    }

    /// <summary>
    /// 动态数据源。
    /// 必须实现BindingList接口
    /// </summary>
    public class ChangeThead
    {
        readonly BindingList<DetectResult> collection = new BindingList<DetectResult>();
        readonly SynchronizationContext context;
        object lockObj = new object();

        public ChangeThead(SynchronizationContext context)
        {
            this.context = context;
            //模拟数据
            for (int i = 0; i < new Random().Next(10); i++)
            {
                collection.Add(new DetectResult());
            }            
        }

        public IList List { get { return this.collection; } }

        
        public void Do()
        {
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());
            collection.Add(new DetectResult());

            
            int postedOperation = 0;
            Interlocked.Increment(ref postedOperation);
            context.Post((x) => {
                if (collection[0].Speed == DetectResultStatus.Wait)
                    collection[0].Speed = DetectResultStatus.Qualified;
                else
                    collection[0].Speed = DetectResultStatus.Wait;
                collection.ResetItem(0);
                Interlocked.Decrement(ref postedOperation);
            }, null);
            

        }
    }
}
