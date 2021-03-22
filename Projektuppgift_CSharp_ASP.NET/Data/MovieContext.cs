namespace Projektuppgift_CSharp_ASP.NET.Data
{
    using Microsoft.EntityFrameworkCore;
    using Projektuppgift_CSharp_ASP.NET.Models;

    /*En databas kontext-klass skapas*/
    /// <summary>
    /// Defines the <see cref="MovieContext" />.
    /// </summary>
    public class MovieContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{MovieContext}"/>.</param>
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Movie.
        /// </summary>
        public virtual DbSet<Movie> Movie { get; set; }
    }
}
