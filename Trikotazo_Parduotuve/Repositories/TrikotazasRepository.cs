namespace Trikotazo_Parduotuve.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Trikotazo_Parduotuve.Entities;
    public class TrikotazasRepository : IRepository<Trikotazas>
    {
        private readonly StoreDataContext _context;
        public TrikotazasRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Trikotazas>> GetAllAsync()
        {
            return await _context.Trikotazai
                 .FromSqlRaw("SELECT * FROM trikotazas")
                 .ToListAsync();
        }

        public async Task<List<Trikotazas>> GetFilteredBySubkategorija(string pavadinimas, int lytis)
        {
            return await _context.Trikotazai
                .FromSqlRaw("SELECT * FROM trikotazas WHERE Fk_SUBKATEGORIJA_pav = {0} AND Fk_SUBKATEGORIJA_lytis = {1}",
                pavadinimas, lytis)
                .ToListAsync();
        }

        public Task<Trikotazas> GetByKey()
        {
            throw new NotImplementedException();
        }

        public Task UpdateEntity(Trikotazas entity)
        {
            throw new NotImplementedException();
        }
    }
}
