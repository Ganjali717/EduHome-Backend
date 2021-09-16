using Microsoft.EntityFrameworkCore;
using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Cources> Cource { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Events> Event { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
