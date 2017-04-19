using JKCS.ML.POC.DB;
using JKCS.ML.POC.Entities;
using JKCS.ML.POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JKCS.ML.POC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel useroLogin)
        {
            using (var context = new MLContext())
            {
                User userEntity = context.User.Where(u => u.Email.Equals(useroLogin.Email)).SingleOrDefault();
                if (userEntity != null)
                {
                    if (userEntity.Password.Equals(useroLogin.Password))
                    {
                        FormsAuthentication.SetAuthCookie(userEntity.Email, false);
                        if (userEntity.Role.Equals("Admin"))
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            return RedirectToAction("Index", "User");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Login failed. password is incorrect");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You are not registered");
                }
                return View();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOff()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }
    }
}