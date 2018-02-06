using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace YZXDMS.SQLServer
{
    public class YZXSQLServerContext: DbContext
    {
        public YZXSQLServerContext()
            : base("name=YZXEntities")
        {
        }

        public YZXSQLServerContext(string connection):base(connection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        //public virtual DbSet<BFD> BFD { get; set; }
        //public virtual DbSet<CarInfo> CarInfo { get; set; }
        //public virtual DbSet<ComplexResult> ComplexResult { get; set; }
        //public virtual DbSet<FaceTable> FaceTable { get; set; }
        //public virtual DbSet<ParkBFD> ParkBFD { get; set; }
        //public virtual DbSet<Powers> Powers { get; set; }
        //public virtual DbSet<SafaResult> SafaResult { get; set; }
        //public virtual DbSet<Speed> Speed { get; set; }
        //public virtual DbSet<TestResult> TestResult { get; set; }
        //public virtual DbSet<TestSpeed> TestSpeed { get; set; }
        //public virtual DbSet<Users> Users { get; set; }
        //public virtual DbSet<WaitDetection> WaitDetection { get; set; }

        public virtual DbSet<Models.Users> Users { get; set; }

    }
}

