using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.Entities.EntityConfigurations
{
    public class JobConfiguration : EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            HasKey(r => r.JobId);
            HasRequired(r => r.User).WithMany(o => o.Jobs).HasForeignKey(r => r.UserId);
        }
    }
}