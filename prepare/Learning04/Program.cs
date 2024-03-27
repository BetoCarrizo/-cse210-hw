using System;

class Program
{
    static void Main(string[] args)
    {
        Assigmnet a1 = new Assigmnet("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSumary());

        MathAssignment math1= new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSumary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writ1= new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writ1.GetSumary());
        Console.WriteLine(writ1.GetWritingInformation());
    }
}