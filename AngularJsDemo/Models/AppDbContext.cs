using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AngularJsDemo.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Make>? Makes { get; set; }
        public virtual DbSet<Model>? Models { get; set; }
        public virtual DbSet<Car>? Cars { get; set; }

    }
}
