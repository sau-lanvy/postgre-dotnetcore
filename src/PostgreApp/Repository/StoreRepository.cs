using System.Collections.Generic;
using System.Threading.Tasks;
using PostgreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PostgreApp.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context;

        public StoreRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<Store>> GetStoresAsync()
        {
            return await _context.Stores.ToListAsync();
        }

        public async Task InsertStore(Store store)
        {
            _context.Stores.Add(store);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch { }
        }
    }
}
