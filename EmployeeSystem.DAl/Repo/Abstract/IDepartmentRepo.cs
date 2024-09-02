using EmployeeSystem.DAl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Repo.Abstract
{
    public interface IDepartmentRepo
    {
        List<Department> GetAll();
        Department GetById(int id);
        bool Edit(Department department);
        bool Create(Department department);
    }
}
