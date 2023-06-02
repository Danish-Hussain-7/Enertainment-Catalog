public static class Functions
{
    // this function will display the tv show catalog.
    public static void tvshow()

    {

        Tvshowlog log = new Tvshowlog();
        log.start();
    }
}
public static class MovieFunctions
{
    // the following function will display all the Movies in the catalog
    public static void DisplayMovies(Dictionary<string, Movie> movieCatalog)
    {
        foreach (var movie in movieCatalog)
        {
            Console.WriteLine(movie);
        }
    }
    
    public static void Addmovie(Dictionary<string, Movie> movieCatalog)
    {
        // this below will instruct the user to inpiut all the properties needed for the movie catalog
        Console.WriteLine("add movie name");
        var Title = Console.ReadLine();
        Console.WriteLine("add movie year");
        int Year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("add Director name");
        var Director = Console.ReadLine();
        Console.WriteLine("add Producer name");
        var Producer = Console.ReadLine();
        Console.WriteLine("add Budget in millions");
        int Budgetinmillions = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the movie actors (separate each actor with a space):");
        List<string> movieActors = Console.ReadLine().Split(' ').ToList();

        // then i Used the .Add function to add the user's  Movie to the Catalog
        movieCatalog.Add(Title, new Movie
        {
            Title = Title,
            Year = Year,
            Director = Director,
            Producer = Producer,
            BudgetinMillions = Budgetinmillions,
            Actors = movieActors
        });


    }
    // this function is used to allow the user to search for actor by typing in the movie name they acted in
    public static void Searchforactorbymovie(Dictionary<string, Movie> movieCatalog)
    {

        // the user will input tyhe movie name
        Console.WriteLine("Enter a movie title to search for: ");
        var searchmovie = Console.ReadLine();
        // this will search for the  movie in the catalog
        if (movieCatalog.TryGetValue(searchmovie, out var movie))
        {
            Console.WriteLine($"Title: {movie.Title}");
            Console.WriteLine($"Year: {movie.Year}");
            Console.WriteLine($"Director: {movie.Director}");
            Console.WriteLine($"Producer: {movie.Producer}");
            Console.WriteLine($"Budget to the nearest  Million: {movie.BudgetinMillions}");
            Console.WriteLine("Actors:");
            //this will search for the actor in the movie and display them
            foreach (var actor in movie.Actors)
            {
                Console.WriteLine($"- {actor}");
            }
        }
        // if not found this message will show up
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, that movie was not found in the catalog.");
            Console.ResetColor();
        }


    }
    // this function will allow the user to remove a movie from the catalog
    public static void removeMovie(Dictionary<string, Movie> movieCatalog)
    {
        Console.WriteLine("Enter the name of a movie to remove: ");
        string remove = Console.ReadLine();

        if (movieCatalog.ContainsKey(remove))
        {
            movieCatalog.Remove(remove);
            Console.WriteLine("Movie Succesfully Removed");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Movie not found in the catalog.");
            Console.ResetColor();

        }
    }
    // this function will display the number of movies in the catalog
    public static void countMovies(Dictionary<string, Movie> movieCatalog)
    {
        Console.WriteLine("There are " + movieCatalog.Count + " movies.");
    }
}
public static class ActorsFunctions
{


    // this is will display the actors the same as the moviedisplay function
    public static void displayActors(Dictionary<string, Actors> ActorCatalog)
    {
        foreach (var Actors in ActorCatalog)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(Actors);
        }
    }
    // this function will display the number of actors in the catalog

    public static void countActors(Dictionary<string, Actors> ActorCatalog)
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine("there are " + ActorCatalog.Count + " movies ");
    }
    public static void removeActor(Dictionary<string, Actors> ActorCatalog)
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("Enter the name of a Actor to remove: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        string remove = Console.ReadLine();

        if (ActorCatalog.ContainsKey(remove))
        {
            ActorCatalog.Remove(remove);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Actor Succesfully Removed");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Actor not found in the Actor Catalog.");
        }
    }

    public static void searchmoviebyactorname(Dictionary<string, Actors> ActorCatalog)
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine("Enter a Actor name to search for: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        var searchTerm = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        if (ActorCatalog.TryGetValue(searchTerm, out var Actors))
        {
            Console.WriteLine($"Name: {Actors.Name}");
            Console.WriteLine($"Age: {Actors.Age}");
            Console.WriteLine($"Gender: {Actors.Gender}");
            Console.WriteLine("Movies:");
            foreach (var movies in Actors.Movies)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"- {movies}");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Sorry, that Actor was not found in the catalog.");
        }
    }
    public static void AddActor(Dictionary<string, Actors> ActorCatalog)

    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Actor name");
        Console.ForegroundColor = ConsoleColor.Gray;
        var Name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Actor Gender");
        Console.ForegroundColor = ConsoleColor.Gray;
        var Gender = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Actor Birthplace");
        Console.ForegroundColor = ConsoleColor.Gray;
        var Birthplace = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("aActor Age");
        Console.ForegroundColor = ConsoleColor.Gray;
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter the  actors movies  (separate each movie with a space):");
        Console.ForegroundColor = ConsoleColor.Gray;
        List<string> ActorsMovie = Console.ReadLine().Split(' ').ToList();

        Console.ForegroundColor = ConsoleColor.Gray;
        ActorCatalog.Add(Name, new Actors
        {

            Name = Name,
            Gender = Gender,
            BirthPLace = Birthplace,
            Age = Age,
            Movies = ActorsMovie
        });
    }

}