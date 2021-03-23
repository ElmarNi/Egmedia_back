using Microsoft.AspNetCore.Http;
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

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        [Required]
        public int PortfolioCategoryId { get; set; }

        public virtual ProjectCategory PortfolioCategory { get; set; }
    }
}
