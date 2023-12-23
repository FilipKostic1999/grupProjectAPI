using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    public class Company : Creat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Activity { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
