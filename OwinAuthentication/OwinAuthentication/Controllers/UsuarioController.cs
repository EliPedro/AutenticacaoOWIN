using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using OwinAuthentication.Models;
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

                var usuarioStore = new UserStore<IdentityUser>();
                var usuarioManager = new UserManager<IdentityUser>(usuarioStore);

                //Criar uma identidade

                var usuarioInfo = new IdentityUser()
                {
                    UserName = user.UserName,
                };

                //Gravar

                IdentityResult resultado = usuarioManager.Create(usuarioInfo, user.Senha.ToString());

                //Se OK

                if (resultado.Succeeded)
                {

                    //Autentica e volta para a página inicial

                    var gerenciadorAutenticaao = HttpContext.GetOwinContext().Authentication;

                    var identidadeUsuario = usuarioManager.CreateIdentity(usuarioInfo, DefaultAuthenticationTypes.ApplicationCookie);

                    gerenciadorAutenticaao.SignIn(
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
