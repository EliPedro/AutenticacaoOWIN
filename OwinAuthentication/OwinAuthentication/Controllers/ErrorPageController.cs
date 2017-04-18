using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthentication.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        [HttpGet]
        public ActionResult Notfound()
        {
            return View();
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException),
        View = "PosicaoInvalida")]
       //[HandleError]
        public ActionResult Vizualizar(int? posicao)
        {
            //string[] nomes = new string[] { "Jonas Hirata", "Rafael Cosentino" };

            var lista = new List<string>();
            lista.Add("Jonas Hirata");
            lista.Add("Rafael Cosentino");

            string nome = lista[2];

            return View(); 

        }

        public ActionResult Teste()
        {
            var lista = new List<string>();
            lista.Add("Jonas Hirata");
            lista.Add("Rafael Cosentino");

            ViewData["Elemento"] = lista[1];

            ViewBag.Teste = "2017";

            return View();
        }
    }
}