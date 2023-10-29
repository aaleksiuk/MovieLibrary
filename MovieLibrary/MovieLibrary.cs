using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Models;

namespace MovieLibrary;
public class MoviesList
{
    public List<Movie> Movies;

    public string GetMoviesByDate(int fromDate, int toDate)
    {
        List<string> moviesByDate = new();

        foreach (var movie in Movies)
        {
            if (movie.Date >= fromDate && movie.Date <= toDate)
            {
                moviesByDate.Add(movie.Title);
            }
        }
        return string.Join(", ", moviesByDate);

    }

    public string GetRandomMovie()
    {
        return Movies[new Random().Next(Movies.Count)].ToString();
    }

    public string GetMoviesByActorName(Actor expectedActor)
    {
        List<string> moviesByName = new();
        foreach (var movie in Movies)
        {
            foreach (var actor in movie.Actors)
            {
                if (actor.Equals(expectedActor))
                {
                    moviesByName.Add(movie.Title);
                    break;
                }
            }   
        }
        return string.Join(", ", moviesByName);
    }
}