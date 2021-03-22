namespace Projektuppgift_CSharp_ASP.NET.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Projektuppgift_CSharp_ASP.NET.Data;
    using Projektuppgift_CSharp_ASP.NET.Models;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="MovieController" />.
    /// </summary>
    [Authorize]
    public class MovieController : Controller
    {
        // En privat variabel skapas kallad _context
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly MovieContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieController"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="MovieContext"/>.</param>
        public MovieController(MovieContext context)
        {
            _context = context;
        }

        // Index-operation skapas och listar ut alla instanser från Filmlistan
        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Index()
        {
            List<Movie> movies = _context.Movie.ToList();
            return View(movies);
        }

        // Create-operation som skapar nya instanser till Filmlistan
        /// <summary>
        /// The Create.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpGet]
        public IActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        // Post-instans som lägger till och sparar film-instansen till databaskontexten samt databasen genom vår variabel _context
        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("index");
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

        // Den önskade produkten hämtas och innehållet visas upp på Edit-sidan via id
        /// <summary>
        /// The Edit.
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        //POST-metod som hämtar information från edit GET-metoden och ändrar samt sparar informationen genom EF Core via vår _context variabel
        /// <summary>
        /// The Edit.
        /// </summary>
        /// <param name="movies">The movies<see cref="Movie"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpPost]
        public IActionResult Edit(Movie movies)
        {
            _context.Attach(movies);
            _context.Entry(movies).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // Den önskade produkten hämtas via id och en varningstext visas upp
        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        //POST-metod som hämtar information från delete GET-metoden och tar bort samt sparar informationen genom EF Core via vår _context variabel
        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="movies">The movies<see cref="Movie"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpPost]
        public IActionResult Delete(Movie movies)
        {
            _context.Attach(movies);
            _context.Entry(movies).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
