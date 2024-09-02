using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.ModelVM.EmployeeVM
{
    public class EditEmployeeVM
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
    }
}
