using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFu.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public double Stars { get; set; }
        public string Comments { get; set; }

        public virtual int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}