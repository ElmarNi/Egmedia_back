using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class AboutController : Controller
    {
        private readonly EGmediaDb _context;
        public AboutController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.about.FirstOrDefault());
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(About about)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                ViewBag.Success = "Haqqımızda uğurla dəyişdirildi";
                _context.about.FirstOrDefault().Content = about.Content;
                await _context.SaveChangesAsync();
                return View(_context.about.FirstOrDefault());
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
