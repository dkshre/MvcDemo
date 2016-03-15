using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Demo.Web.Models;

namespace MVC5Demo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext employeeDbContext = new EmployeeDbContext();

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = employeeDbContext.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var employee = new Employee();
                employee.FirstName = viewModel.FirstName;
                employee.LastName = viewModel.LastName;
                employee.JobTitle = viewModel.JobTitle;
                employee.Gender = viewModel.Gender;

                department.Employees.Add(employee);

                employeeDbContext.SaveChanges();

                return RedirectToAction("detail", "department", new { id = viewModel.DepartmentId });
            }

            return View(viewModel);
        }

    }
}