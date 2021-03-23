using EGmediaBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.ViewModels
{
    public class PortfolioVM
    {
        public IEnumerable<ProjectCategory> projectCategories { get; set; }
        public IEnumerable<Project> projects { get; set; }
    }
}
