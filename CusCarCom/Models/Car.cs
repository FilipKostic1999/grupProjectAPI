using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    public class Car : Creat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public string Type { get; set; }
    }
}
