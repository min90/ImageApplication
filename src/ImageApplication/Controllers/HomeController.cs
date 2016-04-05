using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ImageApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
         public IActionResult Index()
         {
            User user = new User { UserID = 1, UserName = "Jesper" };
            return View(user);
         }
    }
}
