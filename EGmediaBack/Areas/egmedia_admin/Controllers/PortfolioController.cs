using EGmediaBack.DAL;
using EGmediaBack.Models;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EGmediaBack.Extensions.IFormFileEx;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class PortfolioController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IWebHostEnvironment _env;

        public PortfolioController(EGmediaDb context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
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
        public IActionResult Categories()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.projectCategories);
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        public IActionResult CategoryCreate()
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
        public async Task<IActionResult> CategoryCreate(ProjectCategory category)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (category.Name == string.Empty || category.Name == "")
                {
                    ModelState.AddModelError("Name", "Ad boş olmamalıdır");
                    return View(category);
                }
                await _context.projectCategories.AddAsync(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Categories));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        public async Task<IActionResult> CategoryUpdate(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (id == null || await _context.projectCategories.FindAsync(id) == null)
                {
                    return NotFound();
                }
                return View(await _context.projectCategories.FindAsync(id));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryUpdate(ProjectCategory category)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (category.Name == string.Empty || category.Name == "" )
                {
                    ModelState.AddModelError("Name", "Ad boş olmamalıdır");
                    return View(category);
                }
                ProjectCategory cat_db = await _context.projectCategories.FindAsync(category.Id);
                cat_db.Name = category.Name;
                cat_db.Status = category.Status;
                cat_db.IsImage = category.IsImage;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Categories));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        public IActionResult Projects()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View(_context.projects.Include(p => p.ProjectCategory).OrderByDescending(p => p.Date));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        public IActionResult ProjectCreate()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                ViewBag.Categories = _context.projectCategories;
                return View();
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ProjectCreate(Project project)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return NotFound();
                    }
                    if (project.Name == string.Empty || project.Name == "")
                    {
                        ModelState.AddModelError("Name", "Ad boş olmamalıdır");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }
                    if (!_context.projectCategories.Any(category => category.Id == project.ProjectCategoryId))
                    {
                        ModelState.AddModelError("ProjectCategoryId", "Layihənin kateqoriyasını seçin");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }
                    ProjectCategory projectCategory = await _context.projectCategories.FindAsync(project.ProjectCategoryId);
                    if (!projectCategory.IsImage && string.IsNullOrEmpty(project.Url))
                    {

                        ModelState.AddModelError("Url", "Url boş olmamalıdır");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }

                    if (project.Image != null)
                    {
                        if (!project.Image.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Image", "Şəkilin formatı düzgün deyil");
                            ViewBag.Categories = _context.projectCategories;
                            return View(project);
                        }
                        project.ImageUrl = await project.Image.SavePhotoAsync(_env.WebRootPath, "projects");
                    }
                    else
                    {
                        ModelState.AddModelError("Image", "Layihənin əsas şəklini seçin");
                        ViewBag.Categories = _context.projectCategories;
                        return View(project);
                    }
                    if (project.ShowInHome && project.Home_Image == null)
                    {
                        ModelState.AddModelError("Home_Image", "Layihənin ana səhifə şəklini seçin");
                        ViewBag.Categories = _context.projectCategories;
                        return View(project);
                    }
                    if (project.Home_Image != null)
                    {
                        if (!project.Home_Image.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Home_Image", "Şəkilin formatı düzgün deyil");
                            ViewBag.Categories = _context.projectCategories;

                            return View(project);
                        }
                        project.Home_ImageUrl = await project.Home_Image.SavePhotoAsync(_env.WebRootPath, "projects");
                    }
                    else
                    {
                        project.Home_ImageUrl = "no_image.jpg";
                    }
                    project.Date = DateTime.Now;
                    await _context.projects.AddAsync(project);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Projects));
                }
                catch(Exception ex)
                {
                    return Content(ex.ToString());
                }
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        public async Task<IActionResult> ProjectUpdate(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (id == null || await _context.projects.FindAsync(id) == null)
                {
                    return NotFound();
                }
                ViewBag.Categories = _context.projectCategories;
                return View(await _context.projects.FindAsync(id));
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ProjectUpdate(Project project)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return NotFound();
                    }
                    if (project.Name == string.Empty || project.Name == "")
                    {
                        ModelState.AddModelError("Name", "Ad boş olmamalıdır");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }
                    if (!_context.projectCategories.Any(category => category.Id == project.ProjectCategoryId))
                    {
                        ModelState.AddModelError("ProjectCategoryId", "Layihənin kateqoriyasını seçin");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }
                    Project project_db = await _context.projects.FindAsync(project.Id);
                    ProjectCategory projectCategory = await _context.projectCategories.FindAsync(project.ProjectCategoryId);

                    if (!projectCategory.IsImage && string.IsNullOrEmpty(project.Url))
                    {

                        ModelState.AddModelError("Url", "Url boş olmamalıdır");
                        ViewBag.Categories = _context.projectCategories;

                        return View(project);
                    }

                    if (project_db == null)
                    {
                        return NotFound();
                    }
                    if (project.Image != null)
                    {
                        if (!project.Image.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Image", "Şəkilin formatı düzgün deyil");
                            ViewBag.Categories = _context.projectCategories;
                            return View(project_db);
                        }
                        RemovePhoto(_env.WebRootPath, project_db.ImageUrl);
                        project_db.ImageUrl = await project.Image.SavePhotoAsync(_env.WebRootPath, "projects");
                    }
                    if (project.Home_Image != null)
                    {
                        if (!project.Home_Image.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Home_Image", "Şəkilin formatı düzgün deyil");
                            ViewBag.Categories = _context.projectCategories;

                            return View(project_db);
                        }
                        RemovePhoto(_env.WebRootPath, project_db.Home_ImageUrl);
                        project_db.Home_ImageUrl = await project.Home_Image.SavePhotoAsync(_env.WebRootPath, "projects");
                    }
                    project_db.Date = DateTime.Now;
                    project_db.Name = project.Name;
                    project_db.Status = project.Status;
                    project_db.ShowInHome = project.ShowInHome;
                    project_db.ProjectCategoryId = project.ProjectCategoryId;
                    project_db.Url = project.Url;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Projects));
                }
                catch(Exception ex)
                {
                    return Content(ex.ToString());
                }
            }
            else
            {
                return Redirect("/egmedia_admin/login");
            }
        }
    }
}
