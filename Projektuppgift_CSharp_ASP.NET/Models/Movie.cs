namespace Projektuppgift_CSharp_ASP.NET.Models
{
    using System.ComponentModel.DataAnnotations;

    /*Movie-klass med Id som primärnyckel samt Titel, Kategori, Längd, Beskrivning och en URL till filmomslag som attribut*/
    /// <summary>
    /// Defines the <see cref="Movie" />.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [MaxLength(70)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [MaxLength(70)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [MaxLength(20)]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets the ImageUrl.
        /// </summary>
        [MaxLength(499)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the TrailerUrl.
        /// </summary>
        [MaxLength(499)]
        public string TrailerUrl { get; set; }

        /// <summary>
        /// Gets or sets the IMDBUrl.
        /// </summary>
        [MaxLength(499)]
        public string IMDBUrl { get; set; }
    }
}
