using ETicaretAPI.Persistence.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretDbContext>
    {
        public ETicaretDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaretDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ETicaretAPIDB;");
            return new ETicaretDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
