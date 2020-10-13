using Microsoft.EntityFrameworkCore;

namespace My_Application.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
            
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Models.OneHundredDay> OneHundredDays { get; set; }
    }
}