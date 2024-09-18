
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignmentProject.Models
{
    public class VehicleDetails
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Car_Name { get; set; }

        [Required]
        [Range(1900,2030)]
        public int Carmodel { get; set; }

        [Required]
        [Display(Name ="Vehicle Registartion Number")]
        public string V_I_N { get; set; }

        [Required]
        public string Color { get; set; }

        [Range(1, 100)]
        [Required]
        public int Milege { get; set; }

        [Required]
        public string FuelType { get; set; }
    }
}
