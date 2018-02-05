using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Helper;
using YZXDMS.IService;

namespace YZXDMS.Utility
{
    /// <summary>
    /// IOC Service Provider
    /// IocContainer.Resolve＜InterfaceType＞
    /// </summary>
    public class IocContainer
    {
        #region IOC Init
        private static readonly Lazy<IocContainer> Provider = new Lazy<IocContainer>(() => new IocContainer());
        private string DBType { get; set; }
        private ContainerBuilder Builder { get; set; }
        public IContainer Container { get; set; }
        private IocContainer()
        {
            this.DBType = AppSettingHelper.Get("DBType");
            this.Builder = new ContainerBuilder();
            this.Register(this.Builder);
            this.Container = this.Builder.Build();
        }
        #endregion

        /// <summary>
        /// 类型注册
        /// </summary>
        public void Register(ContainerBuilder builder)
        {
            if (this.DBType == "MySql")
                this.Builder.RegisterType<MySQLService.YZXDBHelper>().As<IDBHelperService>().SingleInstance();
            //else
            //   this.Builder.RegisterType<MySQLService.YZXDBHelper>().As<IDBHelperService>().SingleInstance();
        }
        /// <summary>
        /// 
        /// </summary>
        public static IocContainer Instance { get { return Provider.Value; } }
        /// <summary>
        /// 解悉类型实例
        /// IocContainer.Resolve＜InterfaceType＞
        /// </summary>
        /// <typeparam name="T">要解悉的接口类型</typeparam>
        /// <returns>对应的接口实例</returns>
        public static T Resolve<T>()
        {
            var provider = Provider.Value;
            return provider.Container.Resolve<T>();
        }
    }
}
