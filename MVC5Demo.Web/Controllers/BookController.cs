using MVC5Demo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Web.Controllers
{
    [Authorize]
    public class BookController: Controller
    {
        private BookDbContext db = new BookDbContext();

        public ActionResult Index()
        {
            return View(db.Books);
        }
    }
}