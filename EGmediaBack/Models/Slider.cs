using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required]
        public string Header_First_Word { get; set; }

        [Required]
        public string Header_Second_Word { get; set; }

        [Required]
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        [Required]
        public string Aside_Header { get; set; }

        public string Aside_ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Aside_Image { get; set; }

        public DateTime Date { get; set; }
    }
}
