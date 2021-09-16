using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class HomeViewModel
    {
        public List<Setting> Settings { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<About> Abouts { get; set; }
        public List<Cources> Cource { get; set; }
        public List<Notice> Notices { get; set; }
        public List<Events> Event { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
