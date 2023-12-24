using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    // Klassen som representerar en kund
    public class Customer : Creat
    {
        // Primärnyckel för kunden
        [Key]
        public int ID { get; set; }

        // Måste finnas med och får inte vara null när en instans av Customer skapas
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        // Måste finnas med och får inte vara null när en instans av Customer skapas
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        // Måste finnas med och får inte vara null när en instans av Customer skapas
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        // Mobilnummer för kunden, kan vara null
        public string Cell { get; set; }
    }
}
