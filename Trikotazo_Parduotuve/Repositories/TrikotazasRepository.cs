namespace Trikotazo_Parduotuve.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Migrations.Operations;
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

        public async Task<Trikotazas> GetByKey(int id)
        {
            return await _context.Trikotazai
                .FromSqlRaw("SELECT * FROM trikotazas WHERE Id = {0}",
                id)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateEntity(int id, Trikotazas trikotazas)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "UPDATE trikotazas SET Pavadinimas = {0}, Kaina = {1}, Medziaga = {2}, Dydis = {3}, Spalva = {4}, Kiekis = {5}, Paskutinis_atnaujinimas = {6}," +
                " Fk_SUBKATEGORIJA_pav = {7}, Fk_SUBKATEGORIJA_lytis = {8}, Fk_TIEKEJAS = {9} WHERE Id = {10}",
                trikotazas.Pavadinimas, trikotazas.Kaina, trikotazas.Medziaga, trikotazas.Dydis, trikotazas.Spalva,
                trikotazas.Kiekis, DateTime.Now, trikotazas.Fk_SUBKATEGORIJA_pav, trikotazas.Fk_SUBKATEGORIJA_lytis,
                trikotazas.Fk_TIEKEJAS, id);
        }

        public async Task Remove(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM trikotazas WHERE Id = {0}",
                id);
        }

        public async Task Add(Trikotazas trikotazas)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "INSERT INTO trikotazas (Pavadinimas, Kaina, Medziaga, Dydis, Spalva, Kiekis, Paskutinis_atnaujinimas, Fk_SUBKATEGORIJA_pav, Fk_SUBKATEGORIJA_lytis, Fk_TIEKEJAS)" +
                "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})",
                trikotazas.Pavadinimas, trikotazas.Kaina, trikotazas.Medziaga, trikotazas.Dydis, trikotazas.Spalva, trikotazas.Kiekis, trikotazas.Paskutinis_atnaujinimas,
                trikotazas.Fk_SUBKATEGORIJA_pav, trikotazas.Fk_SUBKATEGORIJA_lytis, trikotazas.Fk_TIEKEJAS);
        }
    }
}
