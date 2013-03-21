using System.Data.Entity;
using EdsBikeRides.Models;
using EdsBikeRides.Repositories.Interfaces;

namespace EdsBikeRides.Repositories
{
    public class DataContext : DbContext, IUnitOfWork
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<EdsBikeRides.Models.RideContext>());

        public DataContext() : base("name=DataContext")
        {
        }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<Bike> Bikes { get; set; }

        public void Save()
        {
            SaveChanges();
        }  

    }
}
