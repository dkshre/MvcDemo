namespace MVC5Demo.Web.MigrationsForEmployee
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVC5Demo.Web.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5Demo.Web.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigrationsForEmployee";
        }

        protected override void Seed(MVC5Demo.Web.Models.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Department department1 = new Department()
            {
                Name = "IT",
                Location = "New York",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Mark",
                        LastName = "Hastings",
                        Gender = "Male",
                        Salary = 60000,
                        JobTitle = "Developer"
                    },
                    new Employee()
                    {
                        FirstName = "Ben",
                        LastName = "Hoskins",
                        Gender = "Male",
                        Salary = 70000,
                        JobTitle = "Sr. Developer"
                    },
                    new Employee()
                    {
                        FirstName = "John",
                        LastName = "Stanmore",
                        Gender = "Male",
                        Salary = 80000,
                        JobTitle = "Project Manager"
                    }
                }
            };

            Department department2 = new Department()
            {
                Name = "HR",
                Location = "London",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Philip",
                        LastName = "Hastings",
                        Gender = "Male",
                        Salary = 45000,
                        JobTitle = "Recruiter"
                    },
                    new Employee()
                    {
                        FirstName = "Mary",
                        LastName = "Lambeth",
                        Gender = "Female",
                        Salary = 30000,
                        JobTitle = "Sr. Recruiter"
                    }
                }
            };
            Department department3 = new Department()
            {
                Name = "Payroll",
                Location = "Sydney",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Steve",
                        LastName = "Pound",
                        Gender = "Male",
                        Salary = 45000,
                        JobTitle = "Sr. Payroll Admin",
                    },
                    new Employee()
                    {
                        FirstName = "Valarie",
                        LastName = "Vikings",
                        Gender = "Female",
                        Salary = 35000,
                        JobTitle = "Payroll Admin",
                    }
                }
            };



            if (!context.Departments.Any(u => u.Name=="IT"))
            {
                context.Departments.Add(department1);
            }

            if (!context.Departments.Any(u => u.Name == "HR"))
            {
                context.Departments.Add(department2);
            }

            if (!context.Departments.Any(u => u.Name == "Payroll"))
            {
                context.Departments.Add(department3);
            }

            base.Seed(context);

        }
    }
}
