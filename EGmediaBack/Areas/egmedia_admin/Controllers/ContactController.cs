using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class ContactController : Controller
    {
        private readonly EGmediaDb _context;
        public ContactController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.contactMessages.OrderByDescending(m => m.Date).ToList());
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
