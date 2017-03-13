using Microsoft.AspNet.Identity;
using OwinAuthentication.Contexto;
using OwinAuthentication.Models;
using System;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OwinAuthentication.Store
{
    public class UsuarioStore : IUserStore<Usuario,int>, IUserPasswordStore<Usuario, int>
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

        public Task<Usuario> FindByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FindByNameAsync(string userName)
        {

            var id = (from c in db.Set<Usuario>()
                      where c.UserName.Equals(userName)
                      select c.Id).ToList();
            
            var aux = (id.Count > 0 ) ? id[0] : 0;
            
            var usuario = db.Set<Usuario>().Find(aux);

            return Task.FromResult(usuario);

        }
        
        public Task<string> GetPasswordHashAsync(Usuario user)
        {
            var id = (from c in db.Set<Usuario>()
                      where c.UserName.Equals(user.UserName) && c.Senha.Equals(user.Senha)
                      select c.Id).ToList();

            var aux = (id.Count > 0) ? id[0] : 0;

            var usuario = db.Set<Usuario>().Find(aux);

            return Task.FromResult(usuario.Senha);
        }

        public Task<bool> HasPasswordAsync(Usuario user)
        {
            return Task.FromResult(true);
        }

        public Task SetPasswordHashAsync(Usuario user, string passwordHash)
        {
            var result = db.Usuario.Find(user);

            result.Senha = user.Senha;

            db.Entry(result).State = EntityState.Modified;
            db.SaveChanges();

            return Task.FromResult(0);
        }

        public Task UpdateAsync(Usuario user)
        {
            throw new NotImplementedException();
        }

        
    }
}