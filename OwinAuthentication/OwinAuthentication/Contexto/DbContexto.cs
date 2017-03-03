//using OwinAuthentication.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;


//namespace OwinAuthentication.Contexto
//{
//    public class DbContexto : DbContext
//    {

//        public DbContexto() : base("Owin") { }
        

//        public DbSet<Usuario> Usuario { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//        }

//    }
//}