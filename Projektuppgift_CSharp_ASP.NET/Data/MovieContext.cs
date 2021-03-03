using Microsoft.EntityFrameworkCore;
using Projektuppgift_CSharp_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projektuppgift_CSharp_ASP.NET.Data
{
    /*En databas kontext-klass skapas*/
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public virtual DbSet<Movie> Movie { get; set; }
    }
}
