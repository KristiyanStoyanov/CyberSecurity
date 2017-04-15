using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberSecurity.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult RegistrationForm()
        {
            return View();
        }

        public ActionResult ResetPasswordForm()
        {
            return View();
        }

        public ActionResult AssesmentCenter()
        {
            return View();
        }

        public ActionResult ReportGenerator()
        {
            return View();
        }

        public ActionResult LogOutProfile()
        {
            return View();
        }
    }
}