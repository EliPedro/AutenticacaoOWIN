using Microsoft.AspNet.Identity;
using OwinAuthentication.Contexto;
using OwinAuthentication.Models;
using System;
using System.Threading.Tasks;

namespace OwinAuthentication.Store
{
    public class UsuarioStore : IUserStore<Usuario>
    {
        private DbContexto db = new DbContexto();

        public Task CreateAsync(Usuario user)
        {
            db.Usuario.Add(user);

            return db.SaveChangesAsync();
        }

        public Task DeleteAsync(Usuario user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public Task<Usuario> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}