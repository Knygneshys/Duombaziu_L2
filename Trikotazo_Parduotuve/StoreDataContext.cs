using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public StoreDataContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
