﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}