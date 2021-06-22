using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Advantage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kontent boş olmamalıdır.")]
        public string Content { get; set; }

        public string IconUrl { get; set; }

        [NotMapped]
        public IFormFile Icon { get; set; }
    }
}
