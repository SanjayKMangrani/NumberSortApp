using Microsoft.EntityFrameworkCore;

namespace NumberSortApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.SortNumber> SortModels { get; set; }
    }
}
