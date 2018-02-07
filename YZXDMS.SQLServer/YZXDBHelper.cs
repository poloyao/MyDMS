using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.IService;
using YZXDMS.Models;

namespace YZXDMS.SQLServer
{
    public class YZXDBHelper : IDBHelperServer
    {
        string connection;//= "data source=192.168.1.107,50668;initial catalog=YZX;user id=sa;password=yzx;";
        public bool DBExists()
        {
            //throw new NotImplementedException();
            return true;
        }

        public List<Models.Users> GetUsers()
        {
            List<Models.Users> result = new List<Models.Users>();

            using (var db = new YZXSQLServerContext(connection))
            {
                try
                {
                    result = db.Users.ToList();
                }
                catch (Exception ex)
                {
                    Helper.NLogHelper.log.Error(ex.Message);
                }                
            }

            return result;
        }

        public List<YZXDMS.Models.WaitDetection> GetWaitDetections()
        {
            throw new NotImplementedException();
        }

        public List<YZXDMS.Models.WaitDetection> GetWaitDetectionsByStatus(int status, int line)
        {
            throw new NotImplementedException();
        }

        public void SetPath(string path)
        {
            this.connection = path;
        }
    }
}
