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
            

            HomeViewModel homeVM = new HomeViewModel
            {
                Settings = setting,
                Sliders = slider
            };
            return View(homeVM);

            return View();
        }
    }
}
