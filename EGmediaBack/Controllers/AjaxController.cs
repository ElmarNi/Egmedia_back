using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EGmediaBack.Controllers
{
    public class AjaxController : Controller
    {
        private readonly EGmediaDb _context;
        private readonly IConfiguration _configuration;

        public AjaxController(EGmediaDb context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<string> get_price_offer(string name, string number, string email, string message)
        {
            if (name == null || name == "" || name == string.Empty)
            {
                return "name_empty";
            }
            else if (name.Length < 3)
            {
                return "name_short";
            }
            else if (number == null || number == "" || number == string.Empty)
            {
                return "number_empty";
            }
            else if (!Regex.Match(number, @"\+[9]{2}[4]{1}[0-9]{9}$").Success)
            {
                return "number_not_valid";
            }
            else if (email == null || email == "" || email == string.Empty)
            {
                return "email_empty";
            }
            else if (!Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                return "email_not_valid";
            }
            else if (message == null || message == "" || message == string.Empty)
            {
                return "message_empty";
            }
            else
            {
                GetPriceOffer offer = new GetPriceOffer
                {
                    Fullname = name,
                    PhoneNumber = number,
                    Email = email,
                    Message = message,
                    Date = DateTime.Now,
                    IsResponsed = false
                };
                await _context.offers.AddAsync(offer);
                await _context.SaveChangesAsync();
                return "OK";
            }
        }
        public async Task<string> send_message_to_client(int? id, string message, string email)
        {
            if (id == null ||await _context.contactMessages.FindAsync(id) == null || email == "" || email == null)
            {
                return "null";
            }
            if (message == "")
            {
                return "empty";
            }
            MailMessage mailMessage = new System.Net.Mail.MailMessage("info@egmedia.az", email)
            {
                Subject = "test from backend"
            };

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.zoho.com",
                Port = 587,
                Credentials = new System.Net.NetworkCredential("info@egmedia.az", _configuration.GetValue<string>("AdminEmail:password")),
                EnableSsl = true
            };
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = message;
            await smtp.SendMailAsync(mailMessage);
            var message_db = await _context.contactMessages.FindAsync(id);
            message_db.IsResponsed = true;
            await _context.SaveChangesAsync();
            return "ok";
        }
    }
}
