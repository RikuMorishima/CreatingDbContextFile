using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class NameContext : DbContext
    {
        public NameContext(DbContextOptions<NameContext> options) :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }

    }
}