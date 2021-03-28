using EGmediaBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.DAL
{
    public class EGmediaDb : DbContext
    {
        public EGmediaDb(DbContextOptions<EGmediaDb> options) : base(options) { }

        public DbSet<About> about { get; set; }

        public DbSet<ProjectCategory> projectCategories { get; set; }

        public DbSet<Project> projects { get; set; }

        public DbSet<Slider> sliders { get; set; }

        public DbSet<Advantage> advantages { get; set; }

        public DbSet<ServiceCategory> serviceCategories { get; set; }

        public DbSet<Service> services { get; set; }

        public DbSet<ServiceImage> serviceImages { get; set; }

    }
}
