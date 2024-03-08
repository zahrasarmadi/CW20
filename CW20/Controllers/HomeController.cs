using CW20.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW20.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
