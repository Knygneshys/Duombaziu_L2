using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve.Repositories
{
    public class SupplierRepository
    {
        private readonly StoreDataContext _context;

        public SupplierRepository(StoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Supplier>> GetAllSupliersAsync()
        {
            return await _context.Suppliers
                .FromSqlRaw("SELECT * FROM tiekejas")
                .ToListAsync();
        }
    }
}
