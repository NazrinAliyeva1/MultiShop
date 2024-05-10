using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShopTask.DataAccesLayer;

namespace MultiShopTask.Controllers
{
    public class HomeController(MultiShopContext _context) :Controller
    {
        public async Task<IActionResult> Index()
        {
            //List<string> names = ["Sefa", "Nazrin", "Gunay", "Konul"];
            return View(await _context.Categories.ToListAsync());
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
