namespace Projektuppgift_CSharp_ASP.NET.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Projektuppgift_CSharp_ASP.NET.Data;
    using Projektuppgift_CSharp_ASP.NET.Models;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="HomeController" />.
    /// </summary>
    public class HomeController : Controller
    {
        /* Samma _context variabel samt List-metod från MovieController klistras in här för att visa upp film-listan på startskärmen */
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly MovieContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="MovieContext"/>.</param>
        public HomeController(MovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Index()
        {
            List<Movie> movies = _context.Movie.ToList();
            return View(movies);
        }

        // Vald produkt hämtas ut genom id och visas upp på Details-sidan
        /// <summary>
        /// The Details.
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Details(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        /// <summary>
        /// The Error.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
