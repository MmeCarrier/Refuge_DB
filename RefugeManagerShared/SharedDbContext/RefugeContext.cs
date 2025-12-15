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
            public DbSet<Epidemie> Epidemie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) // permet à Entity de comprendre quel côté est dépendant ed l'autre.
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fa>()
                .HasOne(f => f.Animal)
                .WithOne(a => a.Fa)
                .HasForeignKey<Fa>(f => f.AnimalId);

            modelBuilder.Entity<Fa>()
                .HasOne(f => f.Benevole)
                .WithMany(b => b.Fas)
                .HasForeignKey(f => f.BenevoleId);
        }
    }
}
