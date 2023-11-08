using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static EGmediaBack.Extensions.IFormFileEx;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class AdvantagesController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IWebHostEnvironment _env;

        public AdvantagesController(EGmediaDb context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
                return View(_context.advantages.ToList());
            else
                return Redirect("/egmedia_admin/login");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (id != null || _context.advantages.Any(c => c.Id == id))
                    return View(await _context.advantages.FindAsync(id));
                else
                    return NotFound();
            }
            else
                return Redirect("/egmedia_admin/login");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Advantage advantage)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (advantage == null)
                    return NotFound();
                if (advantage.Content == string.Empty || advantage.Content == "")
                {
                    ModelState.AddModelError("Content", "Qısa məlumat boş olmamalıdır");
                    return View(advantage);
                }
                try
                {
                    Advantage db_advantage = await _context.advantages.FindAsync(advantage.Id);
                    if (advantage.Icon != null)
                    {
                        if (!advantage.Icon.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Icon", "Şəkilin formatı düzgün deyil");
                            return View(db_advantage);
                        }
                        RemovePhoto(_env.WebRootPath, db_advantage.IconUrl);
                        db_advantage.IconUrl = await advantage.Icon.SavePhotoAsync(_env.WebRootPath, "advantages");
                    }
                    db_advantage.Content = advantage.Content;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    return Content(ex.ToString());
                }
            }
            else
                return Redirect("/egmedia_admin/login");
        }
    }
}
