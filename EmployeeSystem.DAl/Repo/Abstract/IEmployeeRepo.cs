using EmployeeSystem.DAl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Repo.Abstract
{
    public interface IEmployeeRepo
    {
        IQueryable<Employee> GetAll();
        Employee GetById(int id);
        bool Edit(Employee employee);
        bool Create(Employee employee);
        bool DElete(Employee employee);
    }
}
