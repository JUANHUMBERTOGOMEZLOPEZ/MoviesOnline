using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesOnline.Models
{
    public class Movie
    {
        [Required]
        [StringLength(50, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]     
        public string Title { get; set; }

        [Required]
        public float Duration { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        public string Director { get; set; }

    }


    public class MovieList
    {
        
        public string Title { get; set; }
        public float Duration { get; set; }
        public int year { get; set; }
        public string Director { get; set; }

    }
}