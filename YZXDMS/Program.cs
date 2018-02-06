using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZXDMS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var eww = Data.SQLiteProvider.DBExists();



            //var svc = Data.CurrentDB.GetInstance();
            //var sdss = svc.DBSvc.GetWaitDetectionsByStatus(1, 1);

            //var saas = Helper.SQLiteDBHelper.sqliteHelper;
            //var station = saas.Select("select * from station");

            //var ssss = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.StationModel>(station, 0);
            //var dsdsd = Helper.SQLiteDBHelper.sqliteHelper;

            //var ssss = dsdsd.Select("select * from PortConfig where id == 3");
            //var ssjkkke = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.PortConfig>(ssss, 0);
            //var ssjkkke = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.PortConfig>(ssss, 0);

            //var sss = Data.SQLiteProvider.GetDetectorItems();

            //Models.PortConfig portInfo = new Models.PortConfig()
            //{
            //    Id = 19,
            //    Name = "",
            //    PortName = Models.PortIndex.COM17,
            //    BaudRate = 19200,
            //    StopBits = System.IO.Ports.StopBits.None,
            //    DataBits = 8,
            //    Parity = System.IO.Ports.Parity.None
            //};

            //var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
            ////var ssas = sqlite.Insert("PortConfig", Helper.EntityToDictionary.ToMap(portInfo));

            //var ewew = sqlite.Update("PortConfig", Helper.EntityToDictionary.ToMap(portInfo), "id", 19);

            //var svc = Data.CurrentDB.GetInstance();
            //var sasd = svc.DBSvc.GetUsers();
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login());


            Login fl = new Login();
            fl.ShowDialog();
            if (fl.IsOK)
            {
                fl.Close();
                Application.Run(new Form1());
            }
            else
            {
                return;
            }


        }
    }
}
