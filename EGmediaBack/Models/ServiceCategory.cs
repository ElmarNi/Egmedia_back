using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class ServiceCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Service Service { get; set; }
    }
}
