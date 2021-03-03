using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektuppgift_CSharp_ASP.NET.Data;
using Projektuppgift_CSharp_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projektuppgift_CSharp_ASP.NET.Controllers
{
    public class MovieController : Controller
    {
        // En privat variabel skapas kallad _context
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        // Index-operation skapas och listar ut alla instanser från Filmlistan
        public IActionResult Index()
        {
            List<Movie> movies = _context.Movie.ToList();
            return View(movies);
        }

        // Create-operation som skapar nya instanser till Filmlistan
        [HttpGet]
        public IActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        // Post-instans som lägger till och sparar film-instansen till databaskontexten samt databasen genom vår variabel _context
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // Vald produkt hämtas ut genom id och visas upp på Details-sidan
        public IActionResult Details(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        // Den önskade produkten hämtas och innehållet visas upp på Edit-sidan via id
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        //POST-metod som hämtar information från edit GET-metoden och ändrar samt sparar informationen genom EF Core via vår _context variabel
        [HttpPost]
        public IActionResult Edit(Movie movies)
        {
            _context.Attach(movies);
            _context.Entry(movies).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // Den önskade produkten hämtas via id och en varningstext visas upp
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Movie movie = _context.Movie.Where(movie => movie.Id == Id).FirstOrDefault();
            return View(movie);
        }

        //POST-metod som hämtar information från delete GET-metoden och tar bort samt sparar informationen genom EF Core via vår _context variabel
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
