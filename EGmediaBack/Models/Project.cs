﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad boş olmamalıdır.")]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public string Home_ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Home_Image { get; set; }

        [Required(ErrorMessage = "Layihənin kateqoriyasını seçin")]
        public int ProjectCategoryId { get; set; }

        public bool Status { get; set; }

        public bool ShowInHome { get; set; }

        public string Url { get; set; }

        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}
