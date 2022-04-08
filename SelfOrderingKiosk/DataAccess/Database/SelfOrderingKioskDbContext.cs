using System.Data.Entity;

namespace DataAccess.Database
{
    public class SelfOrderingKioskDbContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataAccess.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public SelfOrderingKioskDbContext()
            : base("name=SelfOrderingKioskDbContext")
        { }
        public virtual DbSet<Product> Products { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
    }
}