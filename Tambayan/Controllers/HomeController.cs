using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tambayan.Models;

namespace Tambayan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    
    }
}
