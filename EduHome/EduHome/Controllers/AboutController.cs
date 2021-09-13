﻿using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        private AppDbContext _context; 
        public AboutController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Setting> setting = _context.Settings.ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Settings = setting
            };
            return View(homeVM);
        }
    }
}
