using Microsoft.AspNetCore.Mvc;
using PartialView.Data;
using PartialView.ViewModels;

namespace PartialView.Controllers
{
    public class HomeController(PustokDbContext pustokDbContext) : Controller
    {
        public IActionResult Index()
        {
            HomeVm homeVm = new()
            {
                Sliders = pustokDbContext.Sliders.ToList()
            };
            return View(homeVm);
        }
    }
}
