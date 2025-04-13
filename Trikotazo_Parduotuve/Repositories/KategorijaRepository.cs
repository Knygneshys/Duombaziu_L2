using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve.Repositories
{
    public class KategorijaRepository : IRepository<Kategorija>
    {
        private readonly StoreDataContext _context;

        public KategorijaRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Kategorija>> GetAllAsync()
        {
            return await _context.Kategorijos
                .FromSqlRaw("SELECT * FROM kategorija")
                .ToListAsync();
        }
    }
}
