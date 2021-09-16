using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Setting> setting = _context.Settings.ToList();
            List<Slider> slider = _context.Sliders.ToList();
            List<Service> service = _context.Services.ToList();
            List<About> about = _context.Abouts.ToList();
            List<Cources> cource = _context.Cource.ToList();
            List<Notice> notice = _context.Notices.ToList();
            List<Events> events = _context.Event.ToList();
            List<Blog> blog = _context.Blogs.ToList();
            

            HomeViewModel homeVM = new HomeViewModel
            {
                Settings = setting,
                Sliders = slider,
                Services = service,
                Abouts = about,
                Cource = cource,
                Notices = notice,
                Event = events,
                Blogs = blog
            };
            return View(homeVM);

            return View();
        }
    }
}
