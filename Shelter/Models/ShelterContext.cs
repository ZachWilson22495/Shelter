using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
    public class ShelterContext : DbContext
    {
        public ShelterContext(DbContextOptions<ShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Rufus", Species = "French Bulldog", Age = 3, Gender = "Male" },
            new Animal { AnimalId = 2, Name = "Felix", Species = "Siamese Cat", Age = 6, Gender = "Male" },
            new Animal { AnimalId = 3, Name = "Annabelle", Species = "English Springer Spaniel", Age = 5, Gender = "Female" },
            new Animal { AnimalId = 4, Name = "Tater Tot", Species = "Pomeranian Dog", Age = 2, Gender = "Male" },
            new Animal { AnimalId = 5, Name = "Princess", Species = "Persian Cat", Age = 1, Gender = "Male" }
      );
}
    }
}