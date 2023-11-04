using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class ProjectCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad boş olmamalıdır.")]
        public string Name { get; set; }

        public bool IsImage { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        [Required(ErrorMessage = "URL boş olmamalıdır.")]
        public string RouteName { get; set; }
    }
}
