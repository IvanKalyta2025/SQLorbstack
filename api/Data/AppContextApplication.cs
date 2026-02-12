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
    }
}