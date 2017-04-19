using JKCS.ML.POC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JKCS.ML.POC.DB
{
    public class MLSeeder : DropCreateDatabaseIfModelChanges<MLContext>
    {
        protected override void Seed(MLContext context)
        {
            User admin = new User()
            {
                Email = "admin@jkcs.com",
                Password = "Admin@123",
                Role = "Admin"
            };

            User userOne = new User()
            {
                Email = "user1@jkcs.com",
                Password = "User@123",
                Role = "Employee"
            };

            User userTwo = new User()
            {
                Email = "user2@jkcs.com",
                Password = "User@123",
                Role = "Employee"
            };

            context.User.Add(admin);
            context.User.Add(userOne);
            context.User.Add(userTwo);

            base.Seed(context);
        }
    }
}