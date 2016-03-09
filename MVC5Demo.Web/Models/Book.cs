using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Demo.Web.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        public Genre Category { get; set; }
    }
}