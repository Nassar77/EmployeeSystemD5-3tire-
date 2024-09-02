using AutoMapper;
using EmployeeSystem.DAl.Entities;
using EmployeeSystem.DAl.Repo.Abstract;
using EmployeeSytem.BLL.ModelVM.DepartmenVM;
using EmployeeSytem.BLL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Services.Implemintation
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepo departmentRepo;
        private readonly IMapper mapper;

        public DepartmentServices(IDepartmentRepo departmentRepo, IMapper mapper)
        {
            this.departmentRepo = departmentRepo;
            this.mapper = mapper;
        }
        #region WithoutMaping
        bool IDepartmentServices.Create(CreateDpertVM department) 
        {
            var data = mapper.Map<Department>(department);
            #region without mapping
            //Department data = new() 
            //{
            //    Id = department.Id,
            //    Name = department.Name
            //};
            #endregion
            return departmentRepo.Create(data); 
        }

        List<GetAllDepartMV> IDepartmentServices.GetAll()
        {
            var data = departmentRepo.GetAll();
            var newdata=mapper.Map<List<GetAllDepartMV>>(data);
            #region without mapping
            //List<GetAllDepartMV> newData = new();
            //foreach (var item in data)
            //{
            //    GetAllDepartMV getAllDepartMV = new GetAllDepartMV()
            //    {
            //        Id = item.Id,
            //        Name = item.Name
            //     };
            //    newData.Add(getAllDepartMV);
            //}
            #endregion
            return newdata;
        }

        #endregion
    }
}
