using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{

    public class Movie
    {
        private string name;
        private double rating;

        public Movie(string name, double rating)
        {
            this.name = name;
            this.rating = rating;
        }

        public double Rating { get => rating; set => rating = value; }

        public string getName()
        {
            return name;
        }
        
    }
}
