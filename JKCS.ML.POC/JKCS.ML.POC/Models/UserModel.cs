using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string Role { get; set; }

        public virtual ICollection<JobModel> Jobs { get; set; }
    }
}