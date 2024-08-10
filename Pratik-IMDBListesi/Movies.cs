using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pratik_IMDBListesi
{
    public class Movies
    {
        public string _movieName { get; set; }
        public double _imdb {  get; set; }

        public Movies(string movieName, double imdb)
        {
            _movieName = movieName;
            _imdb = imdb;
        }
    }
}
