using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinAuthentication.Models
{
    public class ExemploHub : Hub
    {
        public void MensagemParaTodos(string mesagem)
        {
            Clients.All.ExibirMensagem(mesagem);
        }
    }
}