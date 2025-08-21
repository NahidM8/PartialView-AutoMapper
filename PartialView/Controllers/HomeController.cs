using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialView.Models;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
