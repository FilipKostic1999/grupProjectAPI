using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    // En klass som representerar en bil
    public class Car : Creat // Möjlig felstavning, antagligen Creat skulle vara en annan klass
    {
        // Primärnyckel för bilen
        [Key]
        public int ID { get; set; }

        // Måste finnas med och får inte vara null när en instans av Car skapas
        [Required(ErrorMessage = "Make is required")]
        public string Make { get; set; }

        // Måste finnas med och får inte vara null när en instans av Car skapas
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        // Typ av bil, kan vara null
        public string Type { get; set; }
    }
}
