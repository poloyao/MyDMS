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

        #region 移除

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

        #endregion

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
                    result = null;
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// 设置检测项目所属工位
        /// </summary>
        /// <param name="detectors"></param>
        /// <returns></returns>
        public static string SetDetectorsToStation(List<string> detectors,int stationID)
        {
            string result = string.Empty;
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    var query = db.Detector.ToList();
                    foreach (var item in detectors)
                    {
                        var sing = query.Single(x => x.DetectorName == item);
                        sing.StationValue = stationID;
                    }
                    db.SaveChanges();
                    result = string.Empty; ;
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                    Helper.NLogHelper.log.Error(ex.Message);
                }                
            }
            return result;
        }



        /// <summary>
        /// 获取所有的串口信息
        /// </summary>
        /// <returns></returns>
        public static List<PortConfig> GetPortItems()
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
                    result = null;
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }


        /// <summary>
        /// 根据id获取串口信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PortConfig GetPortItemsByID(long id)
        {
            PortConfig result = new PortConfig();
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    result = db.Port.Single(x => x.Id == id);
                }
                catch (Exception ex)
                {
                    result = null;
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

        /// <summary>
        /// 根据detectID获取相关联的辅助设备列表
        /// </summary>
        /// <param name="detectorID"></param>
        /// <returns></returns>
        public static List<AssistModel> GetAssistItemsByDetectID(long detectorID)
        {
            List<AssistModel> result = new List<AssistModel>();
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    var query = db.Assist.Where(x => x.DetectorId == detectorID).ToList();
                    result = query;
                }
                catch (Exception ex)
                {
                    result = null;
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// 获取全部的工位信息
        /// </summary>
        /// <returns></returns>
        public static List<StationModel> GetStationAll()
        {
            List<StationModel> result = new List<StationModel>();
            using (var db = new SQLiteDBContext(path))
            {
                try
                {
                    var query = db.Station.ToList();
                    result = query;
                }
                catch (Exception ex)
                {
                    result = null;
                    Helper.NLogHelper.log.Error(ex.Message);
                }
            }
            return result;
        }



    }

    
}
