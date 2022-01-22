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
            new Animal { AnimalId = 1, Name = "Rufus", Species = "Dog", Breed = "French Bulldog", Age = 3, Sex = "Male" },
            new Animal { AnimalId = 2, Name = "Felix", Species = "Cat", Breed = "Siamese", Age = 6, Sex = "Male" },
            new Animal { AnimalId = 3, Name = "Annabelle", Species = "Dog", Breed = "English Springer Spaniel", Age = 5, Sex = "Female" },
            new Animal { AnimalId = 4, Name = "Tater Tot", Species = "Dog", Breed = "Pomeranian", Age = 2, Sex = "Male" },
            new Animal { AnimalId = 5, Name = "Princess", Species = "Cat", Breed = "Persian",  Age = 1, Sex = "Male" }
      );
}
    }
}