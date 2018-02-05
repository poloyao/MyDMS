using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.IService;
using YZXDMS.Models;

namespace YZXDMS.MySQLService
{
    public class YZXDBHelper : IDBHelperService
    {
        /// <summary>
        /// 是否可连接
        /// </summary>
        public bool IsDBExists = false;

        public static bool TestConnection(string host, int port, int millisecondsTimeout)
        {
            TcpClient client = new TcpClient();
            try
            {
                var ar = client.BeginConnect(host, port, null, null);
                ar.AsyncWaitHandle.WaitOne(millisecondsTimeout);
                return client.Connected;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                client.Close();
            }
        }


        public bool DBExists()
        {
            //mysql 3306
            string ip = "";
            try
            {
                var DBPath = System.Configuration.ConfigurationManager.ConnectionStrings["YZXDB"].ToString();
                string[] service = DBPath.Split(';');
                service = service[0].Split('=');
                ip = service[1];
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error("数据库连接字符串错误：" + ex.ToString());
                return IsDBExists;
            }
            
            if (TestConnection(ip, 3306, 500))
            {

                using (var db = new YZXMySqlContext())
                {
                    IsDBExists = db.Database.Exists();
                }
            }
            if (!IsDBExists)
                Helper.NLogHelper.log.Error("数据库未连接");
            
            return IsDBExists;
        }

        /// <summary>
        /// 获取待检未分配车辆信息表.状态为0的
        /// </summary>
        /// <returns></returns>
        public  List<WaitDetection> GetWaitDetections()
        {
            List<WaitDetection> result = new List<WaitDetection>();
            if (!IsDBExists)
                return result;
            using (var db = new YZXMySqlContext())
            {
                try
                {
                    result = db.WaitDetection.Where(x => x.Status == 0).ToList();
                }
                catch (Exception ex) 
                {
                    Helper.NLogHelper.log.Error(ex.Message);
                }
               
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
            if (!IsDBExists)
                return result;
            using (var db = new YZXMySqlContext())
            {
                try
                {
                    result = db.WaitDetection.Where(x => x.Status == status && x.LineID == line).ToList();
                }
                catch (Exception ex)
                {
                    Helper.NLogHelper.log.Error(ex.Message);
                }               
            }
            return result;
        }
    }
}
