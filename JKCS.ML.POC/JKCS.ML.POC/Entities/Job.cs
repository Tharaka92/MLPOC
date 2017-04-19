using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.Entities
{
    public class Job
    {
        public int JobId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Done { get; set; }
        public virtual User User { get; set; }
    }
}