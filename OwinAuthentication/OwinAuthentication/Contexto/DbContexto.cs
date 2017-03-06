using OwinAuthentication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace OwinAuthentication.Contexto
{
    public class DbContexto : DbContext
    {
     
        public DbSet<Usuario> Usuario { get; set; }

        public DbContexto( ) : base(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\OwinDB.mdf") { }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        // Ou inserindo esta linha no arquivo Web.config

        //   <connectionStrings>     
        //  <add  name="Teste"
        //  connectionString= "Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Teste.mdf; 
        //  Initial Catalog=Teste; Integrated Security=True" 
        //  providerName="System.Data.SqlClient" />  
        //</connectionStrings>
    }
}