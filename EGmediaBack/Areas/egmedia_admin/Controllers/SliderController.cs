using EGmediaBack.DAL;
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
    public class SliderController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IHostingEnvironment _env;

        public SliderController(EGmediaDb context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.sliders.OrderByDescending(s => s.Date));
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
                if (id == null || !_context.sliders.Any(s => s.Id == id))
                {
                    return NotFound();
                }
                return View(await _context.sliders.FindAsync(id));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Slider slider)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (slider.Header_First_Word == "")
                {
                    ModelState.AddModelError("Header_First_Word", "Başlığın birinci sözü boş olmamalıdır");
                    return View(slider);
                }
                if (slider.Header_Second_Word == "")
                {
                    ModelState.AddModelError("Header_Second_Word", "Başlığın ikinci sözü boş olmamalıdır");
                    return View(slider);
                }
                if (slider.Aside_Header == "")
                {
                    ModelState.AddModelError("Aside_Header", "Ikinci başlıq boş olmamalıdır");
                    return View(slider);
                }
                Slider slider_from_db = await _context.sliders.FindAsync(slider.Id);
                if (slider_from_db == null)
                {
                    return NotFound();
                }
                if (slider.Image != null)
                {
                    if (!slider.Image.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Image", "Şəklin formatı düzgün deyil");
                        return View(slider);
                    }
                    RemovePhoto(_env.WebRootPath, slider_from_db.ImageUrl);
                    slider_from_db.ImageUrl = await slider.Image.SavePhotoAsync(_env.WebRootPath, "slider");
                }
                if (slider.Aside_Image != null)
                {
                    if (!slider.Aside_Image.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Aside_Image", "Şəklin formatı düzgün deyil");
                        return View(slider);
                    }
                    RemovePhoto(_env.WebRootPath, slider_from_db.Aside_ImageUrl);
                    slider_from_db.Aside_ImageUrl = await slider.Aside_Image.SavePhotoAsync(_env.WebRootPath, "slider");
                }
                slider_from_db.Header_First_Word = slider.Header_First_Word;
                slider_from_db.Header_Second_Word = slider.Header_Second_Word;
                slider_from_db.Aside_Header = slider.Aside_Header;
                slider_from_db.Content = slider.Content;
                slider_from_db.Date = DateTime.Now;
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
