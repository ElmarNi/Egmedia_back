using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EGmediaBack.DAL;
using EGmediaBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace EGmediaBack.Controllers
{
    public class AjaxController : Controller
    {
        private readonly EGmediaDb _context;
        public AjaxController(EGmediaDb context)
        {
            _context = context;
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
    }
}
