
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignmentProject.Models
{
    public class UserLogin
    {
        [Key]
        public int Emp_id { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Dob { get; set; }
    }
}
