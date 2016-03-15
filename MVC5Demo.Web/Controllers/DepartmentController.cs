using MVC5Demo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly EmployeeDbContext employeeDbContext = new EmployeeDbContext();

        public ActionResult Index()
        {
            var allDepartments = employeeDbContext.Departments;

            return View(allDepartments);
        }

        public ActionResult Detail(int id)
        {
           var model = employeeDbContext.Departments.Single(d => d.Id == id);
            return View(model);
        }
      


    }
}