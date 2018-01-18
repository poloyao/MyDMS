using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Models;

namespace YZXDMS.Data
{
    //public class SQLiteConfiguration : DbConfiguration
    //{
    //    public SQLiteConfiguration()
    //    {
    //        SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
    //        SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
    //        Type t = Type.GetType("System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6");
    //        FieldInfo fi = t.GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
    //        SetProviderServices("System.Data.SQLite", (System.Data.Entity.Core.Common.DbProviderServices)fi.GetValue(null));
    //    }
    //}

    //[DbConfigurationType(typeof(SQLiteConfiguration))]
    public class SQLiteDBContext : DbContext
    {
        public virtual DbSet<PortConfig> Port { get; set; }

        public virtual DbSet<DetectorModel> Detector { get; set; }

        public virtual DbSet<StationModel> Station { get; set; }

        public virtual DbSet<AssistModel> Assist { get; set; }

        public SQLiteDBContext() : base("ConfigDb")
        {
        }

        public SQLiteDBContext(string connStrings) : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = connStrings, ForeignKeys = true }.ConnectionString
        }, true)
        {

        }

        public SQLiteDBContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //// Chinook Database does not pluralize table names
            //modelBuilder.Conventions
            //    .Remove<PluralizingTableNameConvention>();
        }

    }
}
