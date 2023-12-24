using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    // Klassen som representerar skapandet och ändringen av en entitet
    public class Creat
    {
        // Skapad datum för entiteten, måste finnas med när en instans av Creat skapas
        [Required(ErrorMessage = "Created date is required")]
        public DateTime Created { get; set; }

        // Användaren som skapade entiteten
        public string CreatedBy { get; set; }

        // Ändrad datum för entiteten, måste finnas med när en instans av Creat skapas
        [Required(ErrorMessage = "Modified date is required")]
        public DateTime Modified { get; set; }

        // Användaren som ändrade entiteten
        public string ModifiedBy { get; set; }
    }

    // Klassen som representerar felmeddelanden
    public class Error
    {
        // Statusinformation om felet
        public string status { get; set; }

        // Meddelandet som beskriver felet
        public string message { get; set; }
    }
}
