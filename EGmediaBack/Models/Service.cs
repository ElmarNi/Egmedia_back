using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlıq boş olmamalıdır.")]
        public string Heading { get; set; }

        [Required(ErrorMessage = "Kontent boş olmamalıdır.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Kateqoriya adı boş olmamalıdır.")]
        public string CategoryName { get; set; }

        public string CategoryImageUrl { get; set; }

        [NotMapped]
        public IFormFile CategoryImage { get; set; }

        public string CategoryIconUrl { get; set; }

        [NotMapped]
        public IFormFile CategoryIcon { get; set; }

        public virtual ICollection<ServiceImage> Images { get; set; }

        [NotMapped]
        public ICollection<IFormFile> DetailPhotos { get; set; }

        public bool Status { get; set; }
    }
}
