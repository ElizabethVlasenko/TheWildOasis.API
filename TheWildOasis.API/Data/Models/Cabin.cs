using System.ComponentModel.DataAnnotations;

namespace TheWildOasis.API.Data.Models
{
    public class Cabin
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public int MaxCapacity { get; set; }
        [Required]
        public double RegularPrice { get; set; }
        public int? Discount { get; set; }
        public string? Description { get; set; }
        public string? Image {  get; set; }
    
    }
}
