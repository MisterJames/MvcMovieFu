using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieFu.Models
{
    public class Movie
    {
        public Movie()
        {
            this.ReleaseYear = DateTime.Now.Year;
            this.Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1877,2020)]
        public int ReleaseYear { get; set; }

        public virtual int DirectorId { get; set; }
        public virtual Person Director { get; set; }

        public ICollection<Rating> Ratings { get; set; }

    }
}