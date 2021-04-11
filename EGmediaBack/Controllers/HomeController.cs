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
                sliders = _context.sliders.OrderByDescending(s => s.Date).Take(3),
                projects = _context.projects.OrderByDescending(p => p.Date).Take(6),
                advantages = _context.advantages.Take(4),
                serviceCategories = _context.serviceCategories
            };
            return View(homeVM);
        }
    }
}
