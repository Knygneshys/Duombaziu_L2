namespace Trikotazo_Parduotuve.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Trikotazo_Parduotuve.Entities;
    public class F1Repository : IRepository<F1>
    {
        private readonly StoreDataContext _context;
        public F1Repository(StoreDataContext context)
        {
            _context = context;
        }
        public async Task<List<F1>> GetAllAsync()
        {
            return await _context.F1
                .FromSqlRaw("SELECT * FROM subkategorija INNER JOIN kategorija ON subkategorija.Fk_KATEGORIJA = kategorija.Pav")
                .ToListAsync();
        }
    }
}
