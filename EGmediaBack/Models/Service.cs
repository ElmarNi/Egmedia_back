using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Heading { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int ServiceCategoryId { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }

        public ICollection<ServiceImage> Images { get; set; }
    }
}
