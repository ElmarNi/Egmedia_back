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
    [Route("portfolio")]
    public class PortfolioController : Controller
    {
        private readonly EGmediaDb _context;
        public PortfolioController(EGmediaDb context)
        {
            _context = context;
        }

        [Route("{*route}")]
        public IActionResult Index()
        {
            PortfolioVM portfolioVM = new PortfolioVM
            {
                projectCategories = _context.projectCategories.Where(c => c.Status).ToList(),
                projects = _context.projects.Where(p => p.ProjectCategory.Status && p.Status).OrderByDescending(p => p.Date)
            };

            ViewData["imageUrl"] = _context.banners.Where(b => b.WhatFor == "Portfolio").FirstOrDefault().ImageUrl;
            ViewData["name"] = "Portfolio";

            return View(portfolioVM);
        }
    }
}
