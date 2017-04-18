using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthentication.Controllers
{
    [AllowAnonymous]
    public class ChatController : Controller
    {
        [HttpGet]
        public ActionResult Chat()
        {
            return View();
        }
    }
}