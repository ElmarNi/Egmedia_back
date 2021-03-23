using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly EGmediaDb _context;
        public HomeController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                sliders = _context.sliders.OrderByDescending(s => s.Date).Take(3)
            };
            return View(homeVM);
        }
    }
}
