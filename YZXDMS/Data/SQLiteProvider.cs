using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Helper;
using YZXDMS.Models;


namespace YZXDMS.Data
{
    public class SQLiteProvider
    {
        /// <summary>
        /// 你猜
        /// </summary>
        /// <returns></returns>
        public static bool DBExists()
        {
            bool result = false;
            try
            {
                var path = AppSettingHelper.Get("SQLite");
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return result;

        }
        /// <summary>
        /// 获取所有的检测设备信息
        /// </summary>
        /// <returns></returns>
        public static List<DetectorModel> GetDetectorItems()
        {
            try
            {
                List<DetectorModel> result = new List<DetectorModel>();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select("select * from detector");
                result = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.DetectorModel>(queryTable, 0).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }


        /// <summary>
        /// 设置检测项目所属工位
        /// </summary>
        /// <param name="detectors"></param>
        /// <returns></returns>
        public static string SetDetectorsToStation(List<string> detectors, int stationID)
        {
            string result = string.Empty;
            var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
            sqlite.BeginTransaction();
            try
            {
                var dicData = new Dictionary<string, object>();
                dicData.Add("StationValue", stationID);
                foreach (var detectorName in detectors)
                {
                    int affectRow = sqlite.Update("detector", dicData, "DetectorName", detectorName);
                    if (affectRow == 1)
                        result = string.Empty;
                    else
                        throw new Exception("受影响的行数有误！执行回滚操作。");
                }
                sqlite.Commit();
            }
            catch (Exception ex)
            {
                sqlite.Rollback();
                result = ex.Message;
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return result;
        }


        /// <summary>
        /// 获取所有的串口信息
        /// </summary>
        /// <returns></returns>
        public static List<PortConfig> GetPortItems()
        {
            try
            {
                List<PortConfig> result = new List<PortConfig>();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select("select * from PortConfig");
                result = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.PortConfig>(queryTable, 0).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// 根据id获取串口信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PortConfig GetPortItemsByID(long id)
        {
            try
            {
                PortConfig result = new PortConfig();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select($"select * from PortConfig where id == {id}");
                var query = Helper.DataSetToEntityHelper.DataTableToEntityList<PortConfig>(queryTable, 0);
                if (query.Count == 1)
                    return query.First();
                else
                    throw new Exception("查询数据出现错误，不是唯一值");
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// 保存串口信息.
        /// 返回的string为string.Empty则为成功，否则为错误内容。
        /// </summary>
        /// <param name="portInfo">串口信息</param>
        /// <param name="isEdit">是否为修改。默认false新增，true修改</param>
        /// <returns>返回的string为string.Empty则为成功，否则为错误内容。</returns>
        public static string SavePortInfo(PortConfig portInfo, bool isEdit = false)
        {
            string result = string.Empty;
            var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
            sqlite.BeginTransaction();
            try
            {
                int affectRow;

                if (isEdit)
                    affectRow = sqlite.Update("PortConfig", Helper.EntityToDictionary.ToMap(portInfo), "id", portInfo.Id);
                else
                    affectRow = sqlite.Insert("PortConfig", Helper.EntityToDictionary.ToMap(portInfo, "id"));

                if (affectRow == 1)
                    result = string.Empty;
                else
                    throw new Exception("受影响的行数有误！执行回滚操作。");
                sqlite.Commit();
            }
            catch (Exception ex)
            {
                sqlite.Rollback();
                result = ex.Message;
                Helper.NLogHelper.log.Error(ex.Message);
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
            try
            {
                List<AssistModel> result = new List<AssistModel>();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select($"select * from assist where DetectorId = {detectorID}");
                result = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.AssistModel>(queryTable, 0).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }


        /// <summary>
        /// 获取全部的工位信息
        /// </summary>
        /// <returns></returns>
        public static List<StationModel> GetStationAll()
        {
            try
            {
                List<StationModel> result = new List<StationModel>();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select($"select * from Station");
                result = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.StationModel>(queryTable, 0).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }

        public static List<DBSetting> GetDBSetting()
        {
            try
            {
                List<DBSetting> result = new List<DBSetting>();
                var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
                var queryTable = sqlite.Select($"select * from DBSetting where status = 0");
                result = Helper.DataSetToEntityHelper.DataTableToEntityList<Models.DBSetting>(queryTable, 0).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return null;
        }

        public static string GetDBPath()
        {
            string result = string.Empty;
            var query = GetDBSetting();
            if (query != null || query.Count > 0)
            {
                var data = query.Last();
                var pwd = DES.DecryptDES(data.PWD, "syyzx2018");
                result = $"data source={data.IP},{data.Port};initial catalog=YZX;user id=sa;password={pwd};";
            }
            return result;

        }

        /// <summary>
        /// 保存，返回值非empty则错误；
        /// </summary>
        /// <param name="dbType"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string SaveDBSetting(int dbType,string ip,string port, string pwd)
        {
            string result = string.Empty;
            var sqlite = Helper.SQLiteDBHelper.sqliteHelper;
            sqlite.BeginTransaction();
            try
            {
                var dicData = new Dictionary<string, object>();
                dicData.Add("DBType", dbType);
                dicData.Add("IP", ip);
                dicData.Add("Port", port);
                dicData.Add("PWD", pwd);
                dicData.Add("Status", 0);

                int affectRow = sqlite.Insert("DBSetting", dicData);
                if (affectRow == 1)
                    result = string.Empty;
                else
                    throw new Exception("受影响的行数有误！执行回滚操作。");

                sqlite.Commit();
            }
            catch (Exception ex)
            {
                sqlite.Rollback();
                result = ex.Message;
                Helper.NLogHelper.log.Error(ex.Message);
            }
            return result;
        }
        
    }
}
