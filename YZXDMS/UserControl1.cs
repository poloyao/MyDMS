using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZXDMS.Utility;
using YZXDMS.IService;
using Autofac;

namespace YZXDMS
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Data.MySqlContext db = new Data.MySqlContext("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=MySql.Data.MySqlClient;provider connection string=\"server=192.168.1.133;user id=root;password=root;database=yzx\"");
            //var db = new Data.YZXMySqlContext();
            //var sssaa = db.Users.ToList();

            //IContainer container = builder.Build();

            var svc = Data.CurrentDB.GetInstance();
            var as444 = svc.DBSvc.GetWaitDetectionsByStatus(1, 1);

            //var dbSvc = IocContainer.Instance;

            //var ss = dbSvc.Container.Resolve<IDBHelperService>();

            //ss.GetWaitDetectionsByStatus(1, 1);

            //var asss = dbSvc.GetWaitDetectionsByStatus(1, 1);



        }
    }
}
