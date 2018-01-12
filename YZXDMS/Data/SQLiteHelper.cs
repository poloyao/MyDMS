using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Models;

namespace YZXDMS.Data
{
    public class SQLiteHelper
    {
        static string path = @".\db\Config.db";
        //public static void CreateDB()
        //{
        //    SQLiteConnection cn = new SQLiteConnection("data source=" + path);
        //    cn.Open();
        //    cn.Close();
        //}

        //public static void DeleteDB()
        //{
        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }
        //}

        /// <summary>
        /// 获取所有的检测设备信息
        /// </summary>
        /// <returns></returns>
        public static List<DetectorModel> GetDetectorItems()
        {
            List<DetectorModel> result = new List<DetectorModel>();
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    result = db.Detector.ToList();
                }
                catch (Exception ex)
                {
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// 获取所有的串口信息
        /// </summary>
        /// <returns></returns>
        public static List<PortConfig> GetPortItesm()
        {
            List<PortConfig> result = new List<PortConfig>();
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    result = db.Port.ToList();
                }
                catch (Exception ex)
                {
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }


        /// <summary>
        /// 保存串口信息.
        /// 返回的string为string.Empty则为成功，否则为错误内容。
        /// </summary>
        /// <param name="portInfo">串口信息</param>
        /// <param name="isEdit">是否为修改。默认false新增，true修改</param>
        /// <returns>返回的string为string.Empty则为成功，否则为错误内容。</returns>
        public static string  SavePortInfo(PortConfig portInfo, bool isEdit = false)
        {
            string result = string.Empty;
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    if (isEdit)
                    {
                        var old = db.Port.Single(x => x.Id == portInfo.Id);
                        old = portInfo;
                    }
                    else
                    {
                        db.Port.Add(portInfo);
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                    Helper.NLogHelper.log.Error(ex.Message);
                }                              
            }
            return result;           
        }



    }

    
}
