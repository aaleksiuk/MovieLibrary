// See https://aka.ms/new-console-template for more information
using MovieLibrary;
using Newtonsoft.Json;
using System.Security.Principal;


var json = File.ReadAllText(@"C:\Users\aal\source\repos\MovieLibrary\MovieLibrary\movies.json");
// deserialize JSON directly from a file
var movies = JsonConvert.DeserializeObject<MoviesList>(json);

string option;
do
{
    Console.WriteLine("1 – Enter two dates to present movies from that range");
    Console.WriteLine("2 – Display all info about random movie");
    Console.WriteLine("3 – Enter actor's name to display all movies he acts");
    Console.WriteLine("4 – End program\n");
    option = Console.ReadLine();
    int fromDate;
    int toDate;
    string actorName;

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter first date");
            fromDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second date");
            toDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(movies.GetMoviesByDate(fromDate, toDate));
            break;
        case "2":
            Console.WriteLine(movies.GetRandomMovie());
            break;
        case "3":
            Console.WriteLine("Enter actor to display all movies he acts");
            Console.WriteLine(movies.GetMoviesByActorName(new Actor() { FirstName = Console.ReadLine(), LastName = Console.ReadLine() })); ;
            break;
        default:
            break;
    }
} while (option != "4");