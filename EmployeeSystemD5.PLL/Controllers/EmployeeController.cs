using EmployeeSytem.BLL.ModelVM.EmployeeVM;
using EmployeeSytem.BLL.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystemD5.PLL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            this.employeeServices = employeeServices;
        }
        public IActionResult Index()
        {
          var data=  employeeServices.GetAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeVM employeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    employeeServices.Create(employeeVM);
                    return RedirectToAction("Index");
                }

                return View(employeeVM);
            }catch (Exception ) 
            {
                return View(employeeVM);
            }
               
           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data=employeeServices.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(EditEmployeeVM employeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    employeeServices.Edit(employeeVM);
                    return RedirectToAction("Index");
                }

                return View(employeeVM);
            }
            catch (Exception ex )
            {
                ViewBag.Message = ex.Message;
                return View(employeeVM);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = employeeServices.GetById(id);
            try
            {

                if (data != null)
                {
                    DeleteEmployeeVM newdata = new() 
                    { 
                        Id=data.Id,
                        IsDelete=data.IsDelete,
                    };
                    
                   var employee = employeeServices.Delete(newdata);
                    return RedirectToAction("Index", "Employee");
                }
                return View(data);

            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(data);
            }
           
        }
       
        public IActionResult GetEmp() 
        {
            return View();
        }
        
		public IActionResult Get(int id)
		{
			var data = employeeServices.GetById(id);
			return View(data);
		}


	}
}
