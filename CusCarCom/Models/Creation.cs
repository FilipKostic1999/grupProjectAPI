using System.ComponentModel.DataAnnotations;

namespace CCC.Models
{
    public class Creat
    {
        [Required]
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class Error
    {
        public string status { get; set; }
        public string message { get; set; }
    }
}
