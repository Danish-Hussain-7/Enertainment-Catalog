using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

class Tvshowlog
{


    Dictionary<Tvshow, int> log = new Dictionary<Tvshow, int>();
    public void start()

    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        string showtitle = "           -------- Tv Show Catalog  -------- ";
        int delay = 300;

        // this foreach loop will go through each character and print  it out one at a time  
        foreach (char t in showtitle)
        {

            Console.Write(t);

            //this will move the text towards the right direction 
            Console.CursorLeft++;

            // this thread will  wait for the delay i have set in the integer called delay 
            System.Threading.Thread.Sleep(delay);
        }


        while (true)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   ");
            Console.WriteLine("A to add");
            Console.WriteLine("D to display shows");
            Console.WriteLine("S to Save");
            Console.WriteLine("L to  Load");
            Console.WriteLine("R to  Remove");
            Console.WriteLine("Q to  Return to the movie");

            Console.ForegroundColor = ConsoleColor.Gray;
            var input = Console.ReadLine().ToUpper();


            if (input == "A")
            {
                Add();
            }
            else if (input == "D")
            {
                Display();
            }
            else if (input == "S")
            {
                save();
            }
            else if (input == "L")
            {
                load();
            }
            else if (input == "R")
            {

                Remove();
            }
            else if (input == "Q")
            {

                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" choose a option from the menu ");
            }
            void Remove()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please enter a Show to remove");
                Console.ForegroundColor = ConsoleColor.Gray;
                string name = Console.ReadLine().Trim();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" How many seasons");
                Console.ForegroundColor = ConsoleColor.Gray;
                float seasons = Convert.ToSingle(Console.ReadLine());
                Tvshow tvshow = new Tvshow(name, seasons);
                log.Remove(tvshow);
            }
        }
        void Add()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is the show name ");
            string name = Console.ReadLine().Trim();
            Console.WriteLine(" how many seasons");
            float seasons = Convert.ToSingle(Console.ReadLine());
            Tvshow tvshow = new Tvshow(name, seasons);
            log.Add(tvshow, 0);
        }
        void Display()
        {
            foreach (var pair in log)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Tvshow tvshow = pair.Key;
                Console.WriteLine($" Name {tvshow.Name} seasons {tvshow.Seasons.ToString()}");
            }
        }
        void save()
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            // this will create a file called tvshow.txt where it will store the tv shows 
            FileStream file = new FileStream("tvshow.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(file, log);
            file.Close();
        }
        void load()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            // this will open the tvshow.txt file and display the file
            FileStream file = new FileStream("tvshow.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            log = binaryFormatter.Deserialize(file) as Dictionary<Tvshow, int>;
            file.Close();
            Console.ResetColor();
        }
    }

}

