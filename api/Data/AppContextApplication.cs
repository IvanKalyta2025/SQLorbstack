using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class AppContextApplication : DbContext
    {
        public AppContextApplication(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
        }

        public DbSet<BmwM90> BmwM90Ordinary { get; set; }

    }
}