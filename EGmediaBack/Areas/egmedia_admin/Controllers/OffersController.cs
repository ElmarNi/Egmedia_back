using EGmediaBack.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class OffersController : Controller
    {
        private readonly EGmediaDb _context;
        public OffersController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.offers.OrderByDescending(o => o.Date).ToList());
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
