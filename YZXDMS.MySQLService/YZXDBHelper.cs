using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.IService;
using YZXDMS.Models;

namespace YZXDMS.MySQLService
{
    public class YZXDBHelper : IDBHelperService
    {
        /// <summary>
        /// 获取待检未分配车辆信息表.状态为0的
        /// </summary>
        /// <returns></returns>
        public  List<WaitDetection> GetWaitDetections()
        {
            List<WaitDetection> result = new List<WaitDetection>();
            using (var db = new YZXMySqlContext())
            {
                result = db.WaitDetection.Where(x => x.Status == 0).ToList();
            }
            return result;
        }

        /// <summary>
        /// 获取指定状态和线号的待检车辆信息
        /// </summary>
        /// <param name="status"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public  List<WaitDetection> GetWaitDetectionsByStatus(int status, int line)
        {
            List<WaitDetection> result = new List<WaitDetection>();
            using (var db = new YZXMySqlContext())
            {
                result = db.WaitDetection.Where(x => x.Status == status && x.LineID == line).ToList();
            }

            return result;
        }
    }
}
