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
    public class PortfolioController : Controller
    {
        private readonly EGmediaDb _context;
        public PortfolioController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioVM portfolioVM = new PortfolioVM
            {
                projectCategories = _context.projectCategories.ToList(),
                projects = _context.projects.OrderByDescending(p => p.Date)
            };
            return View(portfolioVM);
        }
    }
}
