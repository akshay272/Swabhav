using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHeadFirstJava.Model

{
    class MovieTestDrive
    {
        static void Main(string[] args)
        {
            //for DvdPlayer
            DvdPlaer dvd = new DvdPlaer();
            dvd.runningStatus = true;
            if (dvd.isRunning())
            {
                Console.WriteLine("DVD is running........");
            }
            else
            {
                Console.WriteLine("Dvd is not running");
            }

            Movie movie1 = new Movie();
            Movie movie2 = new Movie();

            //for movie1
            movie1.title = "Hacker";
            movie1.language = "English";
            movie1.genre = "thriller";
            movie1.rating = 7;
            movie1.PlayIt();
            movie1.DetailsAll();

            //for movie2
            movie2.title = "3 Idiots";
            movie2.language = "Hindi";
            movie2.genre = "Comedy ";
            movie2.rating = 10;
            movie2.PlayIt();
            movie2.GetMovieTitle();
            movie2.GetMovieRating();

            Console.ReadKey();
        }
    }
}
