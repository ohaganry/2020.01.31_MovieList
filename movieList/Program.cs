using System;
using System.Text;
using System.Collections.Generic;

namespace movieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie h1 = new Movie("Horror", "It");
            Movie h2 = new Movie("Horror", "House of 1000 Corpses");
            Movie h3 = new Movie("Horror", "Scream");
            Movie s1 = new Movie("SciFi", "Alien");
            Movie s2 = new Movie("SciFi","Chappie");
            Movie s3 = new Movie("SciFi", "Pitch Black");
            Movie c1 = new Movie("Comedy", "Spaceballs");
            Movie c2 = new Movie("Comedy", "Blockers");
            Movie c3 = new Movie("Comedy", "Dude, Where's my Car?");
            Movie a1 = new Movie("Animated", "Spirited Away");
            Movie a2 = new Movie("Animated", "FernGully");
            Movie a3 = new Movie("Animated", "The Last Unicorn");

            List<Movie> movies = new List<Movie>{h2, h1, h3, s1, s2, s3, c2, c3, c1, a2, a1, a3};
            bool proceed = true;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the GC Movie List");
            while(proceed)
            {
                int genreNumber = Methods.CheckRange(int.Parse(Methods.GetUserInput($"Pick a genre:\n1. Animated\n2. Comedy\n3. Horror\n4. SciFi")), 1, 4);
                string genreChoice = "";
                if(genreNumber == 1)
                {
                    genreChoice = "Animated";
                }
                if(genreNumber == 2)
                {
                    genreChoice = "Comedy";
                }
                if(genreNumber == 3)
                {
                    genreChoice = "Horror";
                }
                if(genreNumber == 4)
                {
                    genreChoice = "SciFi";
                }

                Movie.PrintMoviesByGenre(movies, genreChoice);

                proceed = Methods.ValidateInput(Methods.GetUserInput("Would you like to see another genre?"));
            }

        }
    }
}
