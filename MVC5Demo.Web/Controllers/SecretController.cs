using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Web.Controllers
{
    public class SecretController: Controller
    {
        //Entity frameworks AspNetUsers table's UserName column
        [Authorize(Users = "dkshre@gmail.com")]
        public ContentResult Secret()
        {
            return Content("this is a secret.");
        }
        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("This is NOT a secret.");
        }
    }
}