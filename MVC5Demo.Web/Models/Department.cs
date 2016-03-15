using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Demo.Web.Models
{
    public class Department
    {
        // Scalar Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public virtual List<Employee> Employees { get; set; }
    }
}