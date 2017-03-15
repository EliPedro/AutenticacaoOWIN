using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario user)
        {
            
            if (ModelState.IsValid)
            {
                //Obter a UserStore, UserManager
                
                var usuarioStore = new UsuarioStore();
                var usuarioManager = new UserManager<Usuario, int>(usuarioStore);
                
                IdentityResult resultado = usuarioManager.Create(user);
                    
                //Se OK
                if (resultado.Succeeded)
                {
                    //Autentica e volta para a página inicial

                    var gerenciadorAutenticao = HttpContext.GetOwinContext().Authentication;

                    var identidadeUsuario = usuarioManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    gerenciadorAutenticao.SignIn(
                        new AuthenticationProperties() { }, identidadeUsuario);

                    return RedirectToAction("Index", "Home");

                }

            }
            else //Erro, exibe o erro
            {            

                return View(user);
            }


            return RedirectToAction("Index", "Home");
        }

    }

}
