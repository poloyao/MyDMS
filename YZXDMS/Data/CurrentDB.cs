using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Data
{
    /// <summary>
    /// 当前的数据库
    /// </summary>
    public class CurrentDB
    {
        public IService.IDBHelperService DBSvc;

        private static readonly CurrentDB Instance = new CurrentDB();

        public static CurrentDB GetInstance()
        {
            return Instance;
        }

        private CurrentDB()
        {
            DBSvc = Utility.IocContainer.Resolve<IService.IDBHelperService>();
        }
    }
}
