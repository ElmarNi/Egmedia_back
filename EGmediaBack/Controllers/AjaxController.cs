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
            else if (!Regex.Match(number, @"^[0-9]+$").Success)
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
        public async Task<string> send_message_to_client(int? id, string message, string email, bool isOffer)
        {
            if (id == null || email == "" || email == null)
            {
                return "null";
            }
            if (!_context.offers.Any(o => o.Id == id) && !_context.contactMessages.Any(m => m.Id == id))
            {
                return "null";
            }
            if (message == "")
            {
                return "empty";
            }

            MailMessage mailMessage = new System.Net.Mail.MailMessage("info@egmedia.az", email)
            {
                Subject = "EGmedia - Veb saytların hazırlanması."
            };

            //SmtpClient smtp = new SmtpClient
            //{
            //    Host = "egmedia.az",
            //    Port = 465,
            //    Credentials = new System.Net.NetworkCredential("info@egmedia.az", _configuration["AdminEmail:password"]),
            //    EnableSsl = true
            //};

            mailMessage.IsBodyHtml = true;
            mailMessage.Body = $"<p style='margin:0; margin-bottom:20px'>{message}</p> <p style='margin:0; margin-bottom:5px'>Veb-saytımız: <a href='https://egmedia.az/' target='_blank'>https://egmedia.az/</a></p> <p style='margin:0; margin-bottom:5px'>Bizi instagramda izləyin: <a href='https://www.instagram.com/egmedia.az/' target='_blank'>https://www.instagram.com/egmedia.az/</a></p> <p style='margin:0; margin-bottom:5px'>Sizə bir zəng qədər yaxınıq: <a href='tel:+994558090669'>+994558090669</a></p> <p style='margin:0; margin-bottom:5px'><a href='https://egmedia.az/' target='_blank'><img src='https://egmedia.az/img/logo.png' width='400' height='120' /></a></p>";

            //await smtp.SendMailAsync(mailMessage);

            using (var smtp = new SmtpClient())
            {
                smtp.Host = "egmedia.az";
                smtp.Port = 465;
                smtp.Credentials = new System.Net.NetworkCredential("info@egmedia.az", _configuration["AdminEmail:password"]);
                smtp.EnableSsl = true;
                try
                {
                    await smtp.SendMailAsync(mailMessage);
                }
                catch (SmtpException ex)
                {
                    return ex.ToString();
                }
            }

            if (isOffer)
            {
                var offer = await _context.offers.FindAsync(id);
                offer.IsResponsed = true;
            }
            else
            {
                var message_db = await _context.contactMessages.FindAsync(id);
                message_db.IsResponsed = true;
            }

            await _context.SaveChangesAsync();
            return "ok";
        }
    }
}
