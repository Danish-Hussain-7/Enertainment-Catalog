using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
// theese two dictionaries will have some actors and movies aready stored.
var movieCatalog = new Dictionary<string, Movie>();


movieCatalog.Add("The Matrix", new Movie
{
    Title = "The Matrix",
    Year = 1999,
    Director = "Lana Wachowski and Lilly Wachowski",
    Producer = "Lana Wachowski and Lilly Wachowski",
    BudgetinMillions = 63,
    Actors = new List<string> { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" }
});

movieCatalog.Add("Inception", new Movie
{
    Title = "Inception",
    Year = 2010,
    Director = "Christopher Nolan",
    Producer = "Christopher Nolan and Emma Thomas",
    BudgetinMillions = 160,
    Actors = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" }
});

movieCatalog.Add("Interstellar", new Movie
{
    Title = "Interstellar",
    Year = 2014,
    Director = "Christopher Nolan",
    Producer = "Christopher Nolan, Lynda Obst and Emma Thomas",
    BudgetinMillions = 165,
    Actors = new List<string> { "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain" }
});

movieCatalog.Add("Ride Along", new Movie
{
    Title = "Ride Along",
    Year = 2014,
    Director = "Tim Story",
    Producer = "Ice Cube, Will Packer, Larry Brezner and Matt Alvarez",
    BudgetinMillions = 25,
    Actors = new List<string> { "Kevin Hart", "Ice Cube", "Tika Sumpter" }
});

movieCatalog.Add("The Mechanic", new Movie
{
    Title = "The Mechanic",
    Year = 2011,
    Director = " Simon West",
    Producer = "Rob Cowan, René Besson, David Winkler  and William Chartoff",
    BudgetinMillions = 40,
    Actors = new List<string> { "Jasan Statham", "Ben Foster", "Donald Sutherland" }
});

movieCatalog.Add("Boyz N the Hood", new Movie
{
    Title = "Boyz N the Hood",
    Year = 1991,
    Director = "John Singleton",
    Producer = " Steve Nicolaides",
    BudgetinMillions = 6,
    Actors = new List<string> { "Cuba Gooding Jr.", "Ice Cube", "Laurence Fishburne" }
});

movieCatalog.Add("Straight Outta Compton", new Movie
{
    Title = "Straight Outta Compton",
    Year = 2015,
    Director = "F. Gary Gray",
    Producer = "Ice Cube, Dr. Dre, F. Gary Gray, Tomica Woods, Matt Alvarez, Scott Bernstein and Jon Jashni",
    BudgetinMillions = 202,
    Actors = new List<string> { "Dr. Dre", "O'Shea Jackson Jr", "Eazy-E" }
});

movieCatalog.Add("The Gentlemen", new Movie
{
    Title = "The Gentlemen",
    Year = 2019,
    Director = "Guy Ritchie",
    Producer = "Guy Ritchie, Ivan Atkinson, Bill Block",
    BudgetinMillions = 22,
    Actors = new List<string> { "Charlie Hunnam", "Matthew McConaughey", "Colin Farrell" }
});

movieCatalog.Add("Training Day", new Movie
{
    Title = "Training Day",
    Year = 2001,
    Director = "Antoine Fuqua",
    Producer = "David Ayer, Jeffrey Silver and Robert Newmyer",
    BudgetinMillions = 45,
    Actors = new List<string> { "Washington", "Ethan Hawke", "Antoine Fuqua" }
});

movieCatalog.Add("Operation Fortune: Ruse de Guerre", new Movie
{
    Title = "Operation Fortune: Ruse de Guerre",
    Year = 2023,
    Director = "Guy Ritchie",
    Producer = "Jason Statham, Guy Ritchie, Ivan Atkinson, Bill Block and Steven Chasman",
    BudgetinMillions = 22,
    Actors = new List<string> { "Jason Statham", "Aubrey Plaza", "Bugzy Malone" }
});

var ActorCatalog = new Dictionary<string, Actors>();

ActorCatalog.Add("Sylvester Stallone ", new Actors
{
    Name = "Sylvester Stallone",
    Age = 76,
    BirthPLace = "Hell's Kitchen, New York, United States",
    Gender = "Male",
    Movies = new List<string> { "" }
});

ActorCatalog.Add("Salman Khan", new Actors
{
    Name = "Salman Khan",
    Age = 56,
    BirthPLace = "Indore, India",
    Gender = "Male",
    Movies = new List<string> { "Ek Tha Tiger, Bodygaurd, Radhe, Pathaan, Kick" }
});

ActorCatalog.Add("Sha rukh Khan", new Actors
{
    Name = "Sha rukh Khan",
    Age = 57,
    BirthPLace = "New Delhi, India",
    Gender = "Male",
    Movies = new List<string> { "Dilwale, Kal ho naa ho, Kuch Kuch hota hai, Khabi Khushi Khabi Gham, Don" }
});

ActorCatalog.Add("John Abraham", new Actors
{
    Name = "John Abraham",
    Age = 49,
    BirthPLace = "Mumbai, India",
    Gender = "Male",
    Movies = new List<string> { "Ek Villian Returns, Rocky Handsome, Force, Race, Desi Boyz" }
});

ActorCatalog.Add("Sonakshi sinha", new Actors
{
    Name = "Sonakshi sinha",
    Age = 35,
    BirthPLace = "atna, India",
    Gender = "Female",
    Movies = new List<string> { "Rowdy Rathore, Dabangg, Son of sardaar, Boss, Himatwala" }
});

ActorCatalog.Add("Ajay Devgn", new Actors
{
    Name = "Ajay Devgn",
    Age = 53,
    BirthPLace = "New Delhi, India",
    Gender = "Male",
    Movies = new List<string> { "Singham, Baadshaao, Kaal, Son of Sardaar, Himatwala" }
});

ActorCatalog.Add("Jennifer Aniston", new Actors
{
    Name = " Jennifer Aniston",
    Age = 53,
    BirthPLace = "Sherman Oaks, Los Angeles, California, United States",
    Gender = "female",
    Movies = new List<string> { "The Bounty Hunter, We're the millers, The break up, Picture Perfect, Mother's Day" }
});

ActorCatalog.Add("Denzel Washington ", new Actors
{
    Name = "Denzel Washington",
    Age = 67,
    BirthPLace = "Mount Vernon, New York, United States",
    Gender = "Male",
    Movies = new List<string> { "The Equalizer, Training Day, Man on Fire, Malcolm X, Fences" }
});

ActorCatalog.Add("Will SMith", new Actors
{
    Name = "Will Smith",
    Age = 54,
    BirthPLace = "Philadelphia, Pennsylvania, United States",
    Gender = "Male",
    Movies = new List<string> { "Bad Boys, I am Legend, Focus, Irobot, Hancock" }
});

ActorCatalog.Add("Tom Hardy", new Actors
{
    Name = "Tom Hardy",
    Age = 45,
    BirthPLace = "Hammersmith, London",
    Gender = "Male",
    Movies = new List<string> { "Venom, Lawless, Mad max, Dunmkirk, Capone" }
});
Console.ForegroundColor = ConsoleColor.Cyan;

string Maintitle = "             -------- Movie Catalog  -------- ";
int delay = 300;

// this foreach loop will go through each character and print  it out one at a time  
foreach (char t in Maintitle)
{

    Console.Write(t);

    //this will move the text towards the right direction 
    Console.CursorLeft++;

    // this thread will  wait for the delay i have set in the integer called delay 
    Thread.Sleep(delay);
}
Console.ResetColor();
while (true)
{


    // this is the main menu for my program
    Console.WriteLine("           ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("1) Display movie list");
    Console.WriteLine("2)  Add Movie to list");
    Console.WriteLine("3) Count number of movies");
    Console.WriteLine("4)  Search for actor using a movie");
    Console.WriteLine("5)  Remove a Movie");
    Console.WriteLine("6)  Display Actor List");
    Console.WriteLine("7)  add Actor to List");
    Console.WriteLine("8) Count number of Actors ");
    Console.WriteLine("9)  Search For movie Using Actor Name ");
    Console.WriteLine("10) remove Actor");
    Console.WriteLine("Q) Quit");
    Console.WriteLine("11)  Go to Tvshow menu");
    Console.WriteLine("           ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" PLease chose a option: ");
    Console.ForegroundColor = ConsoleColor.Gray;
    string choice = Console.ReadLine().ToUpper();
    Console.ResetColor();

    Console.WriteLine("           ");
    if (choice == "Q") break;
    // this try catch  will catch a incorrect input from the user  and display my custom error message 
    try
    {




        if (choice == "1") MovieFunctions.DisplayMovies(movieCatalog);
        else if (choice == "2") MovieFunctions.Addmovie(movieCatalog);
        else if (choice == "3") MovieFunctions.countMovies(movieCatalog);
        else if (choice == "4") MovieFunctions.Searchforactorbymovie(movieCatalog);
        else if (choice == "5") MovieFunctions.removeMovie(movieCatalog);
        else if (choice == "6") ActorsFunctions.displayActors(ActorCatalog);
        else if (choice == "7") ActorsFunctions.AddActor(ActorCatalog);
        else if (choice == "8") ActorsFunctions.countActors(ActorCatalog);
        else if (choice == "9") ActorsFunctions.searchmoviebyactorname(ActorCatalog);
        else if (choice == "10") ActorsFunctions.removeActor(ActorCatalog);
        else if (choice == "11") Functions.tvshow();
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("This option is not recognized Please choose a number between 1-11  or press Q to exit");
        }








    }


    catch (Exception error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error.Message);
    }

    Console.ResetColor();
}

