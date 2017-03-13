using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using OwinAuthentication.Models;
using OwinAuthentication.Store;
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

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if(ModelState.IsValid)
            { 
            var usuarioStore = new UsuarioStore();
            var usuarioManager = new UserManager<Usuario, int>(usuarioStore);

            var usuario = usuarioManager.FindByName(login.Nome);

            if (usuario != null)
            {

                var gerenciadorDeAutenticacao = HttpContext.GetOwinContext().Authentication;
                var identidadeUsuario = usuarioManager.CreateIdentity(usuario, DefaultAuthenticationTypes.ApplicationCookie);
                gerenciadorDeAutenticacao.SignIn(new AuthenticationProperties() { IsPersistent = false }, identidadeUsuario);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","Usuário ou senha invalida.");

                return View(login);
            }
           }

            return View(login);

        }

        public ActionResult Logout()
        {
            var gerenciadorDeAutenticacao = HttpContext.GetOwinContext().Authentication;

            gerenciadorDeAutenticacao.SignOut();

            return RedirectToAction("Login");
        }
    }
}