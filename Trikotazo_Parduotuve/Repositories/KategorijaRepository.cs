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

        public async Task<Kategorija> GetByKey(string pav)
        {
            return await _context.Kategorijos
                .FromSqlRaw("SELECT * FROM kategorija WHERE Pavadinimas = {0}", pav)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateEntity(Kategorija kategorija)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "UPDATE kategorija SET Aprasymas = {0} WHERE Pavadinimas = {1}",
                kategorija.Aprasymas, kategorija.Pavadinimas);
        }
    }
}
