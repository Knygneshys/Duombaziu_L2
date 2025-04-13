using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Kategorija> Kategorijos { get; set; }
        public DbSet<Subkategorija> Subkategorijos { get; set; }
        public DbSet<Trikotazas> Trikotazai { get; set; }

        public StoreDataContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
