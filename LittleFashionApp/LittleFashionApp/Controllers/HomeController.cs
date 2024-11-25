using LittleFashionApp.DAL;
using LittleFashionApp.Models;
using LittleFashionApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace LittleFashionApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext context;
        public HomeController(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm()
            {
                products= context.Products.ToList(),
                sliders= context.Sliders.ToList(),

            };
            return View(vm);
        }
    }
}
