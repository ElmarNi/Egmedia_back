using EGmediaBack.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class ServicesController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IHostingEnvironment _env;

        public ServicesController(EGmediaDb context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.services);
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
