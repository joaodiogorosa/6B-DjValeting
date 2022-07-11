using System.ComponentModel.DataAnnotations;

namespace DjValeting.MVC.Models
{
    public class ClientModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        
        public DateTime BookingDate { get; set; }

        [Required]
        public int Flexibility { get; set; }
        
        [Required]
        public int VehicleSize { get; set; }
        
        [Required]
        public string ContactNumber { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        public bool? Approved { get; set; }
    }
}
