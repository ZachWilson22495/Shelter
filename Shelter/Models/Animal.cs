using System.ComponentModel.DataAnnotations;

namespace Shelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public string Sex { get; set; }
  }
}
