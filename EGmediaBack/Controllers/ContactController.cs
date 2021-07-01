using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using EGmediaBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EGmediaBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly EGmediaDb _context;

        public ContactController(EGmediaDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.message = "";
            ViewBag.color = "";
            ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM message)
        {

            if (message == null || !ModelState.IsValid)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

                return View(message);
            }
            if (message.form.Fullname.Length < 4 || message.form.Fullname.Length == 0 || message.form.Fullname == string.Empty)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

                ModelState.AddModelError("form.Fullname", "Ad və Soyad düzgün deyil.");
                return View(message);
            }
            if (!Regex.Match(message.form.PhoneNumber, @"^[0-9]+$").Success)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

                ModelState.AddModelError("form.PhoneNumber", "Nömrəniz düzgün daxil edilməmişdir.");
                return View(message);
            }
            if (message.form.Message == string.Empty || message.form.Message.Length == 0)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

                ModelState.AddModelError("form.Message", "Mesajınız düzgün deyil.");
                return View(message);
            }

            ContactMessage newMessage = new ContactMessage
            {
                Date = DateTime.Now,
                Fullname = message.form.Fullname,
                PhoneNumber = message.form.PhoneNumber,
                Email = message.form.Email,
                Message = message.form.Message,
                IsResponsed = false
            };
            await _context.contactMessages.AddAsync(newMessage);
            await _context.SaveChangesAsync();
            ViewBag.message = "Mesajınız göndərilmişdir. Ən qısa zamanda geri dönüş edəcəyimizdən əmin ola bilərisniz.";
            ViewBag.color = "text-success";
            ViewBag.Banner = _context.banners.Where(b => b.WhatFor == "Əlaqə").FirstOrDefault().ImageUrl;

            return View(message);
        }
    }
}
 