using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class Advantage
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Icon { get; set; }
    }
}
