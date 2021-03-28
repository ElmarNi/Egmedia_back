using EGmediaBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.ViewModels
{
    public class ServiceVM
    {
        public IEnumerable<ServiceCategory> serviceCategories { get; set; }
        public IEnumerable<Service> services { get; set; }
    }
}
