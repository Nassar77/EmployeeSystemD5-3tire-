using EmployeeSystem.DAl.Entities;
using EmployeeSytem.BLL.ModelVM.EmployeeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Services.Abstract
{
    public interface IEmployeeServices
    {
        List<GetAllEmployeeVM> GetAll();
        GetByIdEmployeeVM GetById(int id);
        bool Edit(EditEmployeeVM employee);
        bool Create(CreateEmployeeVM employee);
        bool Delete(DeleteEmployeeVM employee);
    }
}
