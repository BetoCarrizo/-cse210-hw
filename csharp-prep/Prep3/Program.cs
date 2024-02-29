using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string port = Console.ReadLine();
        int Magic_number = int.Parse(port);

        Console.WriteLine("  What is your guess? ");
        string Guess = Console.ReadLine();
        int guess_number = int.Parse(Guess);

        int guessCount=1;

        while (guess_number != Magic_number)
            {
                if (guess_number>Magic_number)
                    Console.WriteLine("Lower");
                else if (guess_number<Magic_number)
                    Console.WriteLine("Higher");
                Console.WriteLine("What is your next guess?");
                 Guess=Console.ReadLine();
                 guess_number = int.Parse(Guess);
                 guessCount++; //chat gpt
            }

        Console.WriteLine("You guessed it!");
        Console.WriteLine(guessCount);  
    }
}