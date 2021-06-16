using EGmediaBack.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.ViewModels
{
    public class PortfolioAdminVM
    {
        public Project Project { get; set; }
        public List<SelectListItem> SelectListItems { get; set; }
    }
}
