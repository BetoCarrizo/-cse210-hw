using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        DisplayMessage();
        string userName= PromptUserName();
        int UserNumber=PromptUserNumber();
        int UserSquare=SquareNumber ( UserNumber);
        DisplayResult( UserSquare,  userName);
        

    }
static void DisplayMessage()
    {
        Console.WriteLine(" Welcome to the program!");
    }

static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;   
    }

static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string chose= Console.ReadLine();
        int number = int.Parse(chose);
        return number;
    }
static int SquareNumber(int number)
    {
        int square= number * number;
        return square;
    }

static void DisplayResult(int square, string name)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
}