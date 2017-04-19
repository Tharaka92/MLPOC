using JKCS.ML.POC.Entities;
using JKCS.ML.POC.Entities.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.DB
{
    public class MLContext : DbContext
    {
        public MLContext()
            : base("name=MlPocDb")
        {
        }

        public DbSet<Job> Job
        {
            get;
            set;
        }

        public DbSet<User> User
        {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new JobConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
    }
}