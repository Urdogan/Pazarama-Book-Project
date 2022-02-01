using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PazaramaBookProject.Data;
using PazaramaBookProject.Models;
using PazaramaBookProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly BookContext _context;
        public HomeController(BookContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var model = new ListViewModel()
            {
                Lists = _context.Lists.ToList()
            };
            return View(model);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
