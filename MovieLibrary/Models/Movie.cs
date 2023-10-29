using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Models;

namespace MovieLibrary;

public class Movie
{
    public string Title { get; set; }
    public Director Director { get; set; }
    public string Genre { get; set; }
    public int Date { get; set; }
    public List<Actor> Actors { get; set; }

    public override string ToString()
    {
        string actors = "";
        foreach (var actor in Actors)
        {
            actors += $"{actor}, ";
        };
        return $"Title: {Title}, \nDate: {Date},\nGenre: {Genre},\nDirector: {Director},\nActors: {actors}\n";
    }
}