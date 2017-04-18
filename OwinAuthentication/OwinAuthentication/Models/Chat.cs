using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinAuthentication.Models
{
    public class Chat : Hub
    {
        public void EnviarMensagem(string mensagem)
        {
            Clients.All.PublicarMensagem(mensagem);
        }
    }
}