using System.Linq;
using System.Collections.Generic;
using System;

namespace WcfService
{
    public class Service1 : IService1
    {
        private OwinDBEntities db = new OwinDBEntities();
         
        public IList<Usuario> FindAll()
        {
            return db.Usuario.ToList();
        }
    }
}
