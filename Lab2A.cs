/* Class: CSE 1321L
Section: W1
Term: Spring 24
Instructor: Manosmi Gundu
Name: Robert Conley
Lab#: Lab2A 
*/
class Lab2A
{
    public static void Main(string[] args)
    {
        //define strings
        string name;
        string name2;
        string verb;
        string adverb;
        //User Input to Create the Mad Lib
        Console.WriteLine("Enter a name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter another name:");
        name2 = Console.ReadLine();
        Console.WriteLine("Enter a verb:");
        verb = Console.ReadLine();
        Console.WriteLine("Enter an adverb:");
        adverb = Console.ReadLine();

        //Print the mad lib
        string output = String.Format("Once upon a time there was a person named {0} who had a child named {1}. This child would {2} {3} while singing to strangers.", name, name2, verb, adverb);
        Console.WriteLine(output);
    }
}