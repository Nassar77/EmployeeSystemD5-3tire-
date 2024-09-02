using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        //navigation prop
        public List<Employee>? Employees { get; set; }
    }
}
