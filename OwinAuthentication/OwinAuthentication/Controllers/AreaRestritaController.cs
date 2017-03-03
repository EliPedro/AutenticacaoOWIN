using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthentication.Controllers
{
    public class AreaRestritaController : Controller
    {
        // GET: AreaRestrita

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}