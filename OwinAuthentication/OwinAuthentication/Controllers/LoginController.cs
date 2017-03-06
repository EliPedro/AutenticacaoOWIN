using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthentication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Usuario
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logoff()
        {

            return View();
        }
    }
}