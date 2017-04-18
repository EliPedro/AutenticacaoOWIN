using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using OwinAuthentication.Models;
using OwinAuthentication.Store;

namespace OwinAuthentication.Controllers
{
    public class LoginController : Controller
    {

        /*
         Esse atributo tem o objetivo de proteger o acesso a sua aplicações 
         por pedidos Http falsificados, ele garante que o pedido venha somente 
         da sua View usando uma espécie de "chave".
         */

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var usuarioStore = new UsuarioStore();
                var usuarioManager = new UserManager<Usuario, int>(usuarioStore);

                var usuario = usuarioManager.FindByName(login.Nome);

                if (usuario != null)
                {

                    var gerenciadorDeAutenticacao = HttpContext.GetOwinContext().Authentication;
                    var identidadeUsuario = usuarioManager.CreateIdentity(usuario, DefaultAuthenticationTypes.ApplicationCookie);
                    gerenciadorDeAutenticacao.SignIn(new AuthenticationProperties() { IsPersistent = false }, identidadeUsuario);

                    if(returnUrl == null)
                    {
                        returnUrl = "/Home/Index";
                    }

                    return new RedirectResult(returnUrl);
                }else
                {
                    ModelState.AddModelError("", "Usuário ou senha invalida.");

                    return View(login);

                }
                
            }

            return View();
        }


        public ActionResult Logout()
        {
            var gerenciadorDeAutenticacao = HttpContext.GetOwinContext().Authentication;

            gerenciadorDeAutenticacao.SignOut();

            return RedirectToAction("Login");
        }

        [Authorize]
        public ActionResult Secure()
        {
           
            return View();
        }

    }
}
 