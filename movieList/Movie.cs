using System;
using System.Collections.Generic;

namespace movieList
{
    public class Movie
    {
        public Movie()
        {

        }
        public Movie(string genre, string title)
        {
            Genre = genre;
            Title = title;
        }
        public string Genre {get; set;}
        public string Title {get; set;}

        public static void PrintMoviesByGenre(List<Movie> movies, string selectedGenre)
        {
            foreach(Movie movie in movies)
            {
                if(selectedGenre == movie.Genre)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }
}