﻿using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Models;

namespace YZXDMS.MySQLService
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class YZXMySqlContext : DbContext
    {

        public YZXMySqlContext() : base("name=YZXDB")
        {

        }
        //public YZXMySqlContext(string connStrings):base(new MySqlConnectionFactory().CreateConnection(connStrings))
        //{

        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<WaitDetection> WaitDetection { get; set; }

    }
}
