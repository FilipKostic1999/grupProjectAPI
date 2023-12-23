using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    public class Customer:Creat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Cell { get; set; }
    }
}
