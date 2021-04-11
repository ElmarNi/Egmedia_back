using EGmediaBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> sliders { get; set; }

        public IEnumerable<Project> projects { get; set; }

        public IEnumerable<Advantage> advantages { get; set; }

        public GetPriceOffer offer { get; set; }

        public IEnumerable<ServiceCategory> serviceCategories { get; set; }
    }
}
