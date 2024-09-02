using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.ModelVM.EmployeeVM
{
      public class GetByIdEmployeeVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10, 60)]
        public int Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
        public string? Image {  get; set; }
        public string? DepartmentName { get; set; }
    }
}
