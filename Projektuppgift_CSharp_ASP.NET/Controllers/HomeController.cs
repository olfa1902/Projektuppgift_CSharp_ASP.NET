using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projektuppgift_CSharp_ASP.NET.Data;
using Projektuppgift_CSharp_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projektuppgift_CSharp_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        /* Samma _context variabel samt List-metod från MovieController klistras in här för att visa upp film-listan på startskärmen */
        private readonly MovieContext _context;

        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Movie> movies = _context.Movie.ToList();
            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
