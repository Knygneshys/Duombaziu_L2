namespace Trikotazo_Parduotuve.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Trikotazo_Parduotuve.Entities;
    public class TiekejasRepository : IRepository<Tiekejas>
    {
        private readonly StoreDataContext _context;
        public TiekejasRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Tiekejas>> GetAllAsync()
        {
            return await _context.Tiekejai
                .FromSqlRaw("SELECT * FROM tiekejas")
                .ToListAsync();
        }
    }
}
