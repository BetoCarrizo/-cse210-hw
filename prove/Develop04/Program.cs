using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    public static void DisplayMenu()
    {
        Console.WriteLine("1: Type '1' for the Breathing Activity: ");
        Console.WriteLine("2: Type '2' for the Reflection Activity: ");
        Console.WriteLine("3: Type '3' for the Listing Activity: ");
        Console.WriteLine("4: Type '4' to quit program: ");
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        acvBreathing b = new acvBreathing();
        acvReflection r = new acvReflection();
        acvListing l = new acvListing(); // Pass session duration here

        bool acvrunning = true;

        while (acvrunning)
        {
            DisplayMenu(); // Call the static method using the class name

            string acvMenuEntry = Console.ReadLine();
            int acvIntMenuEntry = int.Parse(acvMenuEntry);

            if (acvIntMenuEntry == 1)
            {
                b.acvStartingMessage();
            }
            else if (acvIntMenuEntry == 2)
            {
                r.acvStartingMessage();
            }
            else if (acvIntMenuEntry == 3)
            {
                l.acvStartingMessage();
            }
            else if (acvIntMenuEntry == 4)
            {
                Console.WriteLine("Bye!");
                acvrunning = false;
            }
            else
            {
                Console.WriteLine("Insert a valid input");
            }
        }
    }
}
