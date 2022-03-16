using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Concrete
{
    public class ETicaretDbContext : DbContext
    {
        public ETicaretDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
       
       
    }
}
