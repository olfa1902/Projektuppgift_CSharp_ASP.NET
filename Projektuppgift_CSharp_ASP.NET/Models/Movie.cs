using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projektuppgift_CSharp_ASP.NET.Models
{
    /*Movie-klass med Id som primärnyckel samt Titel, Kategori, Längd, Beskrivning och en URL till filmomslag som attribut*/
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(70)]
        public string Title { get; set; }

        [MaxLength(70)]
        public string Category { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string Length { get; set; }

        [MaxLength(499)]
        public string ImageUrl { get; set; }
    }
}
