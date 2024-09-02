using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.ModelVM.EmployeeVM
{
    public class CreateEmployeeVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10, 60)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public IFormFile? ImageName { get; set; }
        public string? Image { get; set; }
        public double Salary { get; set; }
        public int DeptId {  get; set; }
    }
}
