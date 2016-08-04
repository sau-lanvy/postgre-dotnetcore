using Microsoft.EntityFrameworkCore;
using PostgreApp.Models;

namespace PostgreApp.Repository
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext() : base()
        { }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        { }

        public DbSet<Store> Stores { get; set; }
    }
}
