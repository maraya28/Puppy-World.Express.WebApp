using Microsoft.EntityFrameworkCore;
using PuppyWorld.Domain;

namespace PuppyWorld.Infrastructure.Persistance
{
    internal class PuppyWorldDbContext : DbContext
    {
        public PuppyWorldDbContext(DbContextOptions<PuppyWorldDbContext> options) : base(options) { }

        public DbSet<PetExample> PetExamples { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}