using Microsoft.EntityFrameworkCore;
//using Domain;
using RefugeManagerShared.SharedEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RefugeManagerShared.SharedDbContext
{
    public class RefugeContext : DbContext
    {
        public RefugeContext(DbContextOptions<RefugeContext> options) : base (options) { }
            public DbSet<Animal> Animal { get; set; }
            public DbSet<Secteur> Secteur { get; set; }
            public DbSet<Benevole> Benevole { get; set; }
            public DbSet<Fa> Fa { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Benevole>().ToTable("Benevole"); // Force le nom de la table
        //}

    }
}
