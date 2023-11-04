using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace EGmediaBack.Controllers
{
    [Route("xidmetler")]
    public class ServicesController : Controller
    {
        private readonly EGmediaDb _context;
        public ServicesController(EGmediaDb context)
        {
            _context = context;
        }

        [Route("{*route}")]
        public IActionResult Index()
        {
            if (Request.Path.Value.Equals("/xidmetler", StringComparison.OrdinalIgnoreCase))
            {
                string route = _context.services.FirstOrDefault().RouteName;
                return Redirect($"/xidmetler/{route}");
            }

            ViewData["imageUrl"] = _context.banners.Where(b => b.WhatFor == "Xidmətlər").FirstOrDefault().ImageUrl;
            ViewData["name"] = "Xidmətlər";
            return View(_context.services.Include(s => s.Images).Where(s => s.Status));
        }
    }
}
