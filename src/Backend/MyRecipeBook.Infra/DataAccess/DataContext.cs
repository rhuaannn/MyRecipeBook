using Microsoft.EntityFrameworkCore;
using MyRecipeBook.Domain.Entites;

namespace MyRecipeBook.Infra.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

    }
}
