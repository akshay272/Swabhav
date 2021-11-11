using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHeadFirstJava.Model
{
    class Movie
    {
        public string title;
        public string genre;
        public string language;
        public int rating;

        public void PlayIt()
        {
            Console.WriteLine("Playing the "+ title +" movie..........");
            
        }
        public void DetailsAll()
        {
            Console.WriteLine("Genre : " + genre);
            Console.WriteLine("Language : " + language);
            Console.WriteLine("Rating :" + rating);
            Console.WriteLine("");
        }
        public void GetMovieTitle()
        {
            Console.WriteLine("title : " + title);
        }
        public void GetMovieGenre()
        {
            Console.WriteLine("Genre : " + genre);
        }
        public void GetMovieLanguage()
        {
            Console.WriteLine("Language : " + language);
        }
        public void GetMovieRating()
        {
            Console.WriteLine("ratings : " + rating);
        }

    }
}
