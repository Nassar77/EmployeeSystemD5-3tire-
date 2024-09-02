using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.ModelVM.EmployeeVM
{
    public class DeleteEmployeeVM
    {
        [Key]
        public int Id { get; set; }
        public bool IsDelete { get; set; }
    }
}
