using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    // Klassen som representerar ett företag
    public class Company : Creat // Möjlig felstavning, antagligen Creat skulle vara en annan klass
    {
        // Primärnyckel för företaget
        [Key]
        public int ID { get; set; }

        // Måste finnas med och får inte vara null när en instans av Company skapas
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        // Måste finnas med och får inte vara null när en instans av Company skapas
        [Required(ErrorMessage = "Activity is required")]
        public string Activity { get; set; }

        // Måste finnas med och får inte vara null när en instans av Company skapas
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        // Adress för företaget, kan vara null
        public string Address { get; set; }
    }
}
