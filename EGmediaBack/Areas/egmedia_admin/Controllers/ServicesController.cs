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

        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View();
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (string.IsNullOrEmpty(service.Heading))
                {
                    ModelState.AddModelError("Heading", "Başlıq boş olmamalıdır");
                    return View(service);
                }
                if (string.IsNullOrEmpty(service.CategoryName))
                {
                    ModelState.AddModelError("CategoryName", "Kateqoriya boş olmamalıdır");
                    return View(service);
                }
                if (service.CategoryIcon == null)
                {
                    ModelState.AddModelError("CategoryIcon", "İkon boş olmamalıdır");
                    return View(service);
                }
                if (!service.CategoryIcon.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("CategoryIcon", "Ikonun formatı düzgün deyil");
                    return View(service);
                }
                if (service.CategoryImage == null)
                {
                    ModelState.AddModelError("CategoryImage", "Kateqoriya şəkli boş olmamalıdır");
                    return View(service);
                }
                if (!service.CategoryImage.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("CategoryImage", "Kateqoriya şəklinin formatı düzgün deyil");
                    return View(service);
                }
                if (service.DetailPhotos == null)
                {
                    ModelState.AddModelError("DetailPhotos", "Şəkillər boş olmamalıdır");
                    return View(service);
                }
                await _context.services.AddAsync(service);
                foreach (var image in service.DetailPhotos)
                {
                    if (!image.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("DetailPhotos", "Şəklin formatı düzgün deyil");
                        return View(service);
                    }
                }

                service.CategoryIconUrl = await service.CategoryIcon.SavePhotoAsync(_env.WebRootPath, "serviceIcons");
                service.CategoryImageUrl = await service.CategoryImage.SavePhotoAsync(_env.WebRootPath, "serviceCategories");

                foreach (var image in service.DetailPhotos)
                {
                    ServiceImage serviceImage = new ServiceImage
                    {
                        ServiceId = service.Id,
                        ImageUrl = await image.SavePhotoAsync(_env.WebRootPath, "service")
                    };
                    await _context.serviceImages.AddAsync(serviceImage);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
                if (id != null || await _context.services.FindAsync(id) != null)
                {
                    return View(await _context.services.FindAsync(id));
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Service service)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (string.IsNullOrEmpty(service.Heading))
                {
                    ModelState.AddModelError("Heading", "Başlıq boş olmamalıdır");
                    return View(service);
                }
                if (string.IsNullOrEmpty(service.CategoryName))
                {
                    ModelState.AddModelError("CategoryName", "Kateqoriya boş olmamalıdır");
                    return View(service);
                }
                Service service_from_db = await _context.services.FindAsync(service.Id);
                if (service.CategoryIcon != null)
                {
                    if (!service.CategoryIcon.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("CategoryIcon", "Ikonun formatı düzgün deyil");
                        return View(service);
                    }
                    else
                    {
                        RemovePhoto(_env.WebRootPath, service_from_db.CategoryIconUrl);
                        service_from_db.CategoryIconUrl = await service.CategoryIcon.SavePhotoAsync(_env.WebRootPath, "serviceIcons");
                    }
                }
                if (service.CategoryImage != null)
                {
                    if (!service.CategoryImage.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("CategoryImage", "Kateqoriya şəklinin formatı düzgün deyil");
                        return View(service);
                    }
                    else
                    {
                        RemovePhoto(_env.WebRootPath, service_from_db.CategoryImageUrl);
                        service_from_db.CategoryImageUrl = await service.CategoryImage.SavePhotoAsync(_env.WebRootPath, "serviceCategories");
                    }
                }
                if (service.DetailPhotos != null)
                {
                    foreach (var image in service.DetailPhotos)
                    {
                        if (!image.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("DetailPhotos", "Şəklin formatı düzgün deyil");
                            return View(service);
                        }
                    }
                    foreach (var image in _context.serviceImages.Where(i => i.ServiceId == service.Id))
                    {
                        RemovePhoto(_env.WebRootPath, image.ImageUrl);
                        _context.serviceImages.Remove(image);
                    }
                    foreach (var image in service.DetailPhotos)
                    {
                        ServiceImage serviceImage = new ServiceImage
                        {
                            ServiceId = service.Id,
                            ImageUrl = await image.SavePhotoAsync(_env.WebRootPath, "service")
                        };
                        await _context.serviceImages.AddAsync(serviceImage);
                    }
                }
                service_from_db.CategoryName = service.CategoryName;
                service_from_db.Heading = service.Heading;
                service_from_db.Content = service.Content;
                service_from_db.Status = service.Status;
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
