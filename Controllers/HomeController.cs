using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using My_Application.Models;
using My_Application.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace My_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
