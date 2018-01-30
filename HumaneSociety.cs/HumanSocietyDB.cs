namespace HumaneSociety.cs
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HumanSocietyDB : DbContext
    {
        public HumanSocietyDB()
            : base("name=HumanSocietyDB")
        {
        }

        public virtual DbSet<Adopters_Log> Adopters_Log { get; set; }
        public virtual DbSet<Animal_Hotel> Animal_Hotel { get; set; }
        public virtual DbSet<Animal_Log> Animal_Log { get; set; }
        public virtual DbSet<Species_Log> Species_Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adopters_Log>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Adopters_Log>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Adopters_Log>()
                .HasMany(e => e.Animal_Log)
                .WithOptional(e => e.Adopters_Log)
                .HasForeignKey(e => e.Adopter);

            modelBuilder.Entity<Animal_Log>()
                .Property(e => e.Animal_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Animal_Log>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Species_Log>()
                .Property(e => e.Species_type)
                .IsUnicode(false);
        }
    }
}
