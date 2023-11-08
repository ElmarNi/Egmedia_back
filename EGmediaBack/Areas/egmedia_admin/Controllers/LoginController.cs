using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EGmediaBack.Areas.egmedia_admin.Controllers
{
    [Area("egmedia_admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> Index(AdminLogin login)
        {
            if (!ModelState.IsValid)
                return NotFound();
            IdentityUser logedUser = await _userManager.FindByNameAsync(login.Username);
            if (logedUser == null)
            {
                ModelState.AddModelError("", "İstifadəçı adı və ya şifrə yanlışdır.");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(logedUser, login.Password, false, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya şifrə yanlışdır.");
                return View();
            }
            if (await _userManager.IsInRoleAsync(logedUser, "admin"))
                return Redirect("/egmedia_admin/dashboard");

            return View(login);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
    }
}
