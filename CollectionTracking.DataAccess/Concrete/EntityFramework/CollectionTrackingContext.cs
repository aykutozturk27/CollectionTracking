using CollectionTracking.Entities.Concrete;
using System.Data.Entity;

namespace CollectionTracking.DataAccess.Concrete.EntityFramework
{
    public class CollectionTrackingContext : DbContext
    {
        public CollectionTrackingContext() : base("CollectionTrackinDb")
        {
            Database.SetInitializer<CollectionTrackingContext>(null);
        }
        public DbSet<Film> Films { get; set; }
    }
}
