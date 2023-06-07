using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Entities;

namespace RepositoryPattern.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Developer>()
                .HasMany(e => e.Projects)
                .WithMany(c => c.Developers)
                .UsingEntity(j => j.ToTable("DeveloperProject"));
        }

    }

}
