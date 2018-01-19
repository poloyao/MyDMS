using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Helper
{

    /// <summary>
    /// SQLite数据库操作类
    /// </summary>
    public static class SQLiteDBHelper
    {
        public static SQLiteHelper sqliteHelper;
        private static SQLiteCommand cmd;
        private static SQLiteConnection conn;

        static SQLiteDBHelper()
        {
            OpenDB();
        }


        /// <summary>
        /// 打开数据库
        /// </summary>
        public static void OpenDB()
        {
            conn = new SQLiteConnection(@"Data Source=|DataDirectory|\db\Config.db");//连接数据库，config.DataSource数据库连接字符串  
            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            sqliteHelper = new SQLiteHelper(cmd);
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void CloseDB()
        {
            conn.Close();
        }


        
    }
}
