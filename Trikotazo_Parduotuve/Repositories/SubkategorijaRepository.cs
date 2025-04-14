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

        public async Task<Subkategorija> GetByKey(string pav, Lytis lytis)
        {
            return await _context.Subkategorijos
                .FromSqlRaw("SELECT * FROM subkategorija WHERE Pavadinimas = {0} and Lytis = {1}",
                pav, (int)lytis)
                .FirstOrDefaultAsync();
        }

        public async Task Remove(Subkategorija subkategorija)
        {
            await _context.Database
                .ExecuteSqlRawAsync("DELETE FROM subkategorija WHERE Pavadinimas = {0} and Lytis = {1}",
                subkategorija.Pavadinimas, (int)subkategorija.Lytis);
        }
    }
}
