using System.Runtime.Serialization.Formatters.Binary;

public class Actors
{
    // i have used constructors in this class. this is used for the name,gender, birthplace age and movies list
    // theese are used in the main program where theese porperties will be declared for the actors catalog.
    
    public string Name { get; set; }
    public string Gender { get; set; }
    public string BirthPLace { get; set; }
    public int Age { get; set; }
    public List<string> Movies { get; set; }


}