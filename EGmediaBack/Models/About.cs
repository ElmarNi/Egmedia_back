using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kontent boş olmamalıdır.")]
        public string Content { get; set; }
    }
}
