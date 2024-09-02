using AutoMapper;
using EmployeeSystem.DAl.Entities;
using EmployeeSystem.DAl.Repo.Abstract;
using EmployeeSytem.BLL.Hellper;
using EmployeeSytem.BLL.ModelVM.EmployeeVM;
using EmployeeSytem.BLL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Services.Implemintation
{
    public class EmployeeServices : IEmployeeServices
    {
        //assign filed 
        private readonly IEmployeeRepo employeeRepo;
        private readonly IMapper mapper;

        public EmployeeServices(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            this.employeeRepo = employeeRepo;
            this.mapper = mapper;
        }

        //method of services
        public bool Delete(DeleteEmployeeVM employee)
        {
            var data=mapper.Map<Employee>(employee);
            #region without mapping
            //Employee data = new() {
            //    Id = employee.Id,
            //    IsDelete = employee.IsDelete,
            //};
            #endregion
            return employeeRepo.DElete(data);
        }
        /*create new employee*/
        bool IEmployeeServices.Create(CreateEmployeeVM employee)
        {
			employee.Image= UploadImage.UploadFile("Profile", employee.ImageName);
            var data=mapper.Map<Employee>(employee);
            #region without mapping
            //Employee data = new()
            //{
            //    Age = employee.Age,
            //    Name = employee.Name,
            //    Email = employee.Name,
            //    Salary = employee.Salary
            //};
            #endregion
            return employeeRepo.Create(data);

        }

        bool IEmployeeServices.Edit(EditEmployeeVM editemployee)
        {
            var newdata = mapper.Map<Employee>(editemployee);
            #region without Mapping
            // Employee data = new() { 
            //    Id=editemployee.Id,
            //   Age = editemployee.Age,
            //    Name = editemployee.Name ,
            //    Email = editemployee.Email,
            //    Salary= editemployee.Salary
            //};
            #endregion
            return employeeRepo.Edit(newdata);
        }
      
        /*Get all employee   */
        List<GetAllEmployeeVM> IEmployeeServices.GetAll()
        {
            var data = employeeRepo.GetAll().ToList();
            var newdata=mapper.Map<List<GetAllEmployeeVM> >(data);
            #region whithout mapping
            //List<GetAllEmployeeVM> newData = new List<GetAllEmployeeVM>();
            //foreach (var item in data)
            //{
            //    GetAllEmployeeVM modelvm = new GetAllEmployeeVM()
            //    {
            //        Name = item.Name,
            //        Age = item.Age,
            //        Id = item.Id,
            //        CreateOn = item.CreateOn,
            //        IsDelete = item.IsDelete,
            //        DepartmentName = item.Department?.Name
            //    };
            //    newData.Add(modelvm);
            //}
            #endregion
            return newdata;

        }
        /*Get the employee by used id */
        GetByIdEmployeeVM IEmployeeServices.GetById(int id)
        {
            var data = employeeRepo.GetById(id);
            var newdata = mapper.Map<GetByIdEmployeeVM>(data);
            #region whithout mapping
            //GetByIdEmployeeVM employee = new()
            //{
            //    Name = data.Name,
            //    Age = data.Age,
            //    Id = data.Id,
            //    CreateOn = data.CreateOn,
            //    IsDelete = data.IsDelete,
            //    DepartmentName = data.Department?.Name,
            //    Salary= data.Salary,
            //    Email= data.Email
            //};
            #endregion
            return newdata;

        }
       


    }
}
