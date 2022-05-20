using Microsoft.EntityFrameworkCore;

namespace MinimalApi
{
    public class ApiDbContext : DbContext 
    {
        public DbSet<Grocery> Groceries => Set<Grocery>();
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
