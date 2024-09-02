using EmployeeSystem.DAl.DB;
using EmployeeSystem.DAl.Entities;
using EmployeeSystem.DAl.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Repo.Implemintation
{
    public class DepartmentRepo:IDepartmentRepo
    {
        readonly ApplicationDBContext _context = new();
        public bool Create(Department dept)
        {
            try
            {
                _context.Department.Add(dept);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Department dept)
        {
            try
            {
                var department = _context.Department.Where(e => e.Id == dept.Id).FirstOrDefault();
                department.Name = dept.Name;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Department> GetAll() => _context.Department.ToList();

        public Department GetById(int id) => _context.Department.Where(e => e.Id == id).FirstOrDefault();

    }
}
