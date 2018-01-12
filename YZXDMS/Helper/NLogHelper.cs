using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Helper
{
    /// <summary>
    /// 省点new就省点吧
    /// </summary>
    public class NLogHelper
    {
        public static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
    }
}
