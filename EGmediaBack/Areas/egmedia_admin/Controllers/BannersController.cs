using EGmediaBack.DAL;
using EGmediaBack.Extensions;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EGmediaBack.Extensions.IFormFileEx;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class BannersController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IHostingEnvironment _env;
        public BannersController(EGmediaDb context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.banners);
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (id == null || !_context.banners.Any(b => b.Id == id))
                {
                    return NotFound();
                }
                return View(await _context.banners.FindAsync(id));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Banner banner)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {

                if (banner.Image != null)
                {
                    if (!banner.Image.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Image", "Şəklin formatı düzgün deyil");
                        return View(banner);
                    }
                    Banner banner_db = await _context.banners.FindAsync(banner.Id);
                    RemovePhoto(_env.WebRootPath, banner_db.ImageUrl);
                    banner_db.ImageUrl = await banner.Image.SavePhotoAsync(_env.WebRootPath, "banners");
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
