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

        public virtual ICollection<Project> Projects { get; set; }

        public bool Status { get; set; }
    }
}
