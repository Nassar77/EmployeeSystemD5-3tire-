using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10, 60)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public double Salary { get; set; }
        public string? Image { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
        //navigation prop
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department? Department { get; set; }
    }
}
