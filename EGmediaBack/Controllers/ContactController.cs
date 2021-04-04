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
        private readonly IConfiguration _configuration;

        public ContactController(EGmediaDb context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.message = "";
            ViewBag.color = "";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM message)
        {
            var password = _configuration.GetValue<string>("Passwords:SenderEmailPassword");

            if (message == null || !ModelState.IsValid)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                return View(message);
            }
            if (message.form.Fullname.Length < 4 || message.form.Fullname.Length == 0 || message.form.Fullname == string.Empty)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ModelState.AddModelError("form.Fullname", "Ad və Soyad düzgün deyil.");
                return View(message);
            }
            if (!Regex.Match(message.form.PhoneNumber, @"\+[9]{2}[4]{1}[0-9]{9}$").Success)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ModelState.AddModelError("form.PhoneNumber", "Nömrəniz düzgün daxil edilməmişdir. Nömrəniz +944XXXXXXXXX formatında olmalıdır");
                return View(message);
            }
            if (message.form.Message == string.Empty || message.form.Message.Length == 0)
            {
                ViewBag.message = "Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.";
                ViewBag.color = "text-danger";
                ModelState.AddModelError("form.Message", "Mesajınız düzgün deyil.");
                return View(message);
            }

            ContactMessage newMessage = new ContactMessage
            {
                Date = DateTime.Now,
                Fullname = message.form.Fullname,
                PhoneNumber = message.form.PhoneNumber,
                Email = message.form.Email,
                Message = message.form.Message
            };
            await _context.contactMessages.AddAsync(newMessage);
            await _context.SaveChangesAsync();
            ViewBag.message = "Mesajınız göndərilmişdir. Ən qısa zamanda geri dönüş edəcəyimizdən əmin ola bilərisniz.";
            ViewBag.color = "text-success";
            message.form.Fullname = "";
            message.form.PhoneNumber = "";
            message.form.Email = "";
            message.form.Message = "";

            return View(message);
        }
    }
}
 