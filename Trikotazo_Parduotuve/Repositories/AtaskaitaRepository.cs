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

        public async Task<List<AtaskaitaTopic>> GetAllTopics(string kategorija, Lytis lytis)
        {
            return await _context.AtaskaitosTopics
                .FromSqlRaw("SELECT subkategorija.Pavadinimas AS Subkategorija, (SELECT COUNT(*) FROM trikotazas WHERE trikotazas.Fk_SUBKATEGORIJA_pav = Subkategorija AND trikotazas.Fk_SUBKATEGORIJA_lytis = {1}) AS Trikotazo_count " +
                "FROM subkategorija " +
                "WHERE subkategorija.Fk_KATEGORIJA = {0} AND subkategorija.Lytis = {1} " +
                "GROUP BY Subkategorija",
                kategorija, (int)lytis)
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
