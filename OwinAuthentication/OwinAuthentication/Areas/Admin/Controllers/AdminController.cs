using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthentication.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            using (var service = new ServiceReference1.Service1Client())
            {

                return View(service.FindAll().ToList());
            }

        }

    }
}