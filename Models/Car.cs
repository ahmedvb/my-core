using System.ComponentModel.DataAnnotations;

namespace my_core.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Brand { get; set; }
        [Required]
        public int ModelYear { get; set; }
        [Required]
        public float Price { get; set; }
    }
}