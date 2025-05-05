namespace Trikotazo_Parduotuve.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Trikotazo_Parduotuve.Entities;
    public class AtaskaitaRepository
    {
        private readonly StoreDataContext _context;

        public AtaskaitaRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<AtaskaitaTopic>> GetAllTopics(string kategorija, Lytis lytis, float minKaina, float maxKaina)
        {
            return await _context.AtaskaitosTopics
                .FromSqlRaw("SELECT subkategorija.Pavadinimas AS Subkategorija, (SELECT COUNT(*) FROM trikotazas WHERE trikotazas.Fk_SUBKATEGORIJA_pav = Subkategorija AND trikotazas.Fk_SUBKATEGORIJA_lytis = {1} AND trikotazas.Kaina BETWEEN {2} AND {3}) AS Trikotazo_count " +
                "FROM subkategorija " +
                "WHERE subkategorija.Fk_KATEGORIJA = {0} AND subkategorija.Lytis = {1} " +
                "GROUP BY Subkategorija",
                kategorija, (int)lytis, minKaina, maxKaina)
                .ToListAsync();
        }

        public async Task<List<AtaskaitaEntry>> GetEntriesByTopic(string subkategorija, Lytis lytis, float minKaina, float maxKaina)
        {
            return await _context.AtaskaitosEntries
                .FromSqlRaw(
                "SELECT subkategorija.Fk_KATEGORIJA AS Kategorija, trikotazas.Fk_SUBKATEGORIJA_lytis AS Lytis, trikotazas.Kaina AS Kaina, tiekejas.Pavadinimas AS Tiekejas " +
                "FROM trikotazas LEFT JOIN subkategorija " +
                "ON trikotazas.Fk_SUBKATEGORIJA_pav = subkategorija.Pavadinimas AND trikotazas.Fk_SUBKATEGORIJA_lytis = subkategorija.Lytis " +
                "LEFT JOIN tiekejas " +
                "ON trikotazas.Fk_TIEKEJAS = tiekejas.Id " +
                "WHERE subkategorija.Pavadinimas = {0} AND Lytis = {1} AND trikotazas.Kaina BETWEEN {2} AND {3}",
                subkategorija, (int)lytis, minKaina, maxKaina)
                .ToListAsync();
        }
        /*
            SELECT subkategorija.Pavadinimas AS Subkategorija, COUNT(*) AS Trikotazo_count
            FROM subkategorija
            WHERE subkategorija.Lytis = 'vyrams'
         */

        //public async Task<Ataskaita> GetAtaskaitaAsync(Ataskaita ataskaita)
        //{
        //    return await _context.Ataskaitos
        //        .FromSqlRaw("SELECT kategorija.Pav, subkategorija.Lytis, trikotazas.Kaina, trikotazas.Fk_TIEKEJAS" +
        //        "WHERE ")
        //        .FirstOrDefaultAsync();
        //}
    }
}
