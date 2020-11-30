using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace filesandobjects
{
    class movie
    {
        string title;
        string rating;
        string year;
        public movie(string _title, string _rating , string _year)
        {
            title = _title;
            rating = _rating;
            year = _year;
        }
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\samples";
            string filename = @"imdb.txt";
            List<string> movielist = File.ReadAllLines(Path.Combine(filepath, filename)).ToList();

            foreach(string movieitem in movielist)
            {
                Console.WriteLine(movieitem);

            }
            
            
        }
    }
}
