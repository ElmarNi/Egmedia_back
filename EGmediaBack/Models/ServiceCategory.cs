using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class ServiceCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public string IconUrl { get; set; }

        [NotMapped]
        public IFormFile Icon { get; set; }

        public bool Status { get; set; }

        public virtual Service Service { get; set; }
    }
}
