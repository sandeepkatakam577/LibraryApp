﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class SandeepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
