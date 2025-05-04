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

        //public async Task<Ataskaita> GetAtaskaitaAsync(Ataskaita ataskaita)
        //{
        //    return await _context.Ataskaitos
        //        .FromSqlRaw("SELECT kategorija.Pav, subkategorija.Lytis, trikotazas.Kaina, trikotazas.Fk_TIEKEJAS" +
        //        "WHERE ")
        //        .FirstOrDefaultAsync();
        //}
    }
}
