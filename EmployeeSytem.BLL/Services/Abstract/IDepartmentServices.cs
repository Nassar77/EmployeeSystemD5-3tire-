using EmployeeSystem.DAl.Entities;
using EmployeeSytem.BLL.ModelVM.DepartmenVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Services.Abstract
{
    public interface IDepartmentServices
    {
        List<GetAllDepartMV> GetAll();
     
        bool Create(CreateDpertVM department);
    }
}
