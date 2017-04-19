using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.Models
{
    public class JobModel
    {
        public int JobId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public virtual UserModel User { get; set; }
    }
}