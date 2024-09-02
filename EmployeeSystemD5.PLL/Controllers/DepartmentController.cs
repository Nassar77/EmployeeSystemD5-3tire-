using EmployeeSystem.DAl.Entities;
using EmployeeSytem.BLL.ModelVM.DepartmenVM;
using EmployeeSytem.BLL.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystemD5.PLL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices departmentServices;
        #region WithoutMaping
        public DepartmentController(IDepartmentServices departmentServices)
        {
            this.departmentServices = departmentServices;
        }
        public IActionResult Index()
        {
            List<GetAllDepartMV> data = departmentServices.GetAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDpertVM createDpertVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    departmentServices.Create(createDpertVM);
                    return RedirectToAction("index", "Department");
                }
                return View(createDpertVM);
            }
            catch (Exception)
            {
                return View(createDpertVM);
            }
        }
        #endregion
    }
}
