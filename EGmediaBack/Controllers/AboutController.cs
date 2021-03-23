using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly EGmediaDb _context;
        public AboutController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.about.FirstOrDefault());
        }
    }
}
