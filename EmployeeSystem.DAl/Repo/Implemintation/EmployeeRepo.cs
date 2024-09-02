using EmployeeSystem.DAl.DB;
using EmployeeSystem.DAl.Entities;
using EmployeeSystem.DAl.Repo.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.DAl.Repo.Implemintation
{
    public class EmployeeRepo:IEmployeeRepo
    {
       private readonly ApplicationDBContext _context = new();
        public bool Create(Employee employee)
        {
            try
            {
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DElete(Employee emp)
        {
            try
            {
                var employee = _context.Employee.Where(e => e.Id == emp.Id).FirstOrDefault();
                employee.IsDelete = !employee.IsDelete;
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Employee employee)
        {
            try
            {
                var emp = _context.Employee.Where(e => e.Id == employee.Id).Include(a => a.Department).FirstOrDefault();
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Age = employee.Age;
                _context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
               
                return false;
            }
        }
        public IQueryable<Employee> GetAll() => _context.Employee.Include(a=>a.Department);

        public Employee GetById(int id) => _context.Employee.Where(e => e.Id == id).Include(a => a.Department).FirstOrDefault();
    }
}
