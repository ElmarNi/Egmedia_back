using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGmediaBack.Controllers
{
    public class ServicesController : Controller
    {
        private readonly EGmediaDb _context;
        public ServicesController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.services.Include(s => s.Images).Where(s => s.Status));
        }
    }
}
