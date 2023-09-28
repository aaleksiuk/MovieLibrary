using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary;
public class MoviesList
{
    public List<Movie> movies;

    public string GetMoviesByDate(int fromDate, int toDate)
    {
        List<string> moviesByDate = new();

        foreach (var movie in movies)
        {
            if ((movie.Date >= fromDate) && (movie.Date <= toDate))
            {
                moviesByDate.Add(movie.Title);
            }
        }
        var result_moviesByDate = String.Join(", ", moviesByDate);
        return result_moviesByDate;
    }

    public string GetRandomMovie()
    {
        Random rnd = new Random();
        int index = rnd.Next(movies.Count);

        var title = "Title: " + movies[index].Title + ", ";
        var date = "Date: " + movies[index].Date + ", ";
        var genre = "Genre: " + movies[index].Genre + ", ";
        var director = "Director: " + movies[index].Director.FirstName + " " + movies[index].Director.LastName + ", ";

        List<string> actors = new();
      
        foreach (var actor in movies[index].actors)
        {
            actors.Add(actor.FirstName + ' ' + actor.LastName);
        }
        var actorsList = "Actors: " + String.Join(", ", actors);

        return title + director + date + genre + actorsList;
    }

    public string GetMoviesByName(string name)
    {
        List<string> moviesByName = new();
        foreach (var movie in movies)
        {
            foreach (var actor in movie.actors)
            {
                if (actor.LastName == name)
                {
                    moviesByName.Add(movie.Title);
                }
            }   
        }
        var result_moviesByName = String.Join(", ", moviesByName);
        return result_moviesByName;
    }
}