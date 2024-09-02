using AutoMapper;
using EmployeeSystem.DAl.Entities;
using EmployeeSytem.BLL.ModelVM.DepartmenVM;
using EmployeeSytem.BLL.ModelVM.EmployeeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Mapping
{
    public class Map:Profile
    {
        public Map()
        {
            CreateMap<Employee,GetAllEmployeeVM>();
            CreateMap<Employee, GetByIdEmployeeVM>();
            CreateMap<EditEmployeeVM, Employee>();
            CreateMap<CreateEmployeeVM, Employee>();
            CreateMap<DeleteEmployeeVM, Employee>();
            CreateMap<CreateDpertVM, Employee>();
            CreateMap<Department,GetAllDepartMV>();
        }
    }
}
