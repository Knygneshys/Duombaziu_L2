using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve.Repositories
{
    public class SubkategorijaRepository : IRepository<Subkategorija>
    {
        private readonly StoreDataContext _context;

        public SubkategorijaRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Subkategorija>> GetAllAsync()
        {
            return await _context.Subkategorijos
                .FromSqlRaw("SELECT * FROM subkategorija")
                .ToListAsync();
        }

        public Task<Subkategorija> GetByKey()
        {
            throw new NotImplementedException();
        }
    }
}
