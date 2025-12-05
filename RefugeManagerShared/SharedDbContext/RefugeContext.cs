using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Entities;


namespace RefugeManager.Api
{
    public class RefugeContext : DbContext
    {
        public RefugeContext(DbContextOptions<RefugeContext> options) : base (options) { }
            public DbSet<Animal> Animals { get; set; }
            public DbSet<Secteur> Secteurs { get; set; }
            public DbSet<Benevole> Benevoles { get; set; }
    }
}
