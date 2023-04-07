using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static EGmediaBack.Extensions.CustomHash;

namespace EGmediaBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _role;
        private readonly IPasswordHasher<IdentityUser> _hash;

        public HomeController(EGmediaDb context, IConfiguration configuration, IPasswordHasher<IdentityUser> hash, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> role)
        {
            _context = context;
            _userManager = userManager;
            _role = role;
            _configuration = configuration;
            _hash = hash;
        }
        public async Task<IActionResult> Index()
        {
            var password = _configuration.GetValue<string>("Admin:Password");
            var username = _configuration.GetValue<string>("Admin:Username");
            if (!await _role.RoleExistsAsync("admin"))
            {
                await _role.CreateAsync(new IdentityRole("admin"));
            }
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                IdentityUser newuser = new IdentityUser
                {
                    UserName = username
                };
                var hashed_password = _hash.HashPassword(newuser, password);
                newuser.PasswordHash = hashed_password;
                await _userManager.CreateAsync(newuser);
                await _userManager.AddToRoleAsync(newuser, "admin");
            }
            HomeVM homeVM = new HomeVM
            {
                sliders = _context.sliders.OrderByDescending(s => s.Date).Take(3),
                projects = _context.projects.Where(p => p.Status && p.ProjectCategory.Status && p.ShowInHome).Include(p => p.ProjectCategory).OrderByDescending(p => p.Date).Take(6),
                advantages = _context.advantages.Take(4),
                services = _context.services.Where(s => s.Status)
            };
            return View(homeVM);
        }

    }

}
