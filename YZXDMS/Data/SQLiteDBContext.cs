using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Models;

namespace YZXDMS.Data
{
    public class SQLiteDBContext : DbContext
    {
        public virtual DbSet<PortConfig> Port { get; set; }

        public virtual DbSet<DetectorModel> Detector { get; set; }

        public virtual DbSet<StationModel> Station { get; set; }

        public virtual DbSet<AssistModel> Assist { get; set; }


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
