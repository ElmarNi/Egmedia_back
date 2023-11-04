using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Controllers
{
    [Route("haqqimizda")]
    public class AboutController : Controller
    {
        private readonly EGmediaDb _context;
        public AboutController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["imageUrl"] = _context.banners.Where(b => b.WhatFor == "Haqqımızda").FirstOrDefault().ImageUrl;
            ViewData["name"] = "Haqqımızda";
            return View(_context.about.FirstOrDefault());
        }
    }
}
