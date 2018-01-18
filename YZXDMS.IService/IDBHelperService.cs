using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Models;

namespace YZXDMS.IService
{
    public interface IDBHelperService
    {
        /// <summary>
        /// 获取待检未分配车辆信息表.状态为0的
        /// </summary>
        /// <returns></returns>
        List<WaitDetection> GetWaitDetections();

        /// <summary>
        /// 获取指定状态和线号的待检车辆信息
        /// </summary>
        /// <param name="status"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        List<WaitDetection> GetWaitDetectionsByStatus(int status, int line);
    }
}
