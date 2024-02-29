using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        int amount=0;
        int largestNumber = int.MinValue;
        int smallestNumber=int.MaxValue;
        while (true)
        {
            Console.WriteLine("Enter number: ");
            string n = Console.ReadLine();
            int number = int.Parse(n);

            if (number == 0)
                {
                break;
                }
            else 
                {
                numbers.Add(number);

                }
            amount++;
             if (number > largestNumber)
                {                    
                largestNumber = number;
                }
            if (number > 0 && number < smallestNumber)
                {
                    smallestNumber = number;
                }
        }
    int sum = 0;  
    foreach ( int number in numbers)
    
            {
            sum += number;
            

            }
            

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is:{(double)sum/amount}");   
            Console.WriteLine ($"The largest number is:{largestNumber}");
            Console.WriteLine ($"The smallest positive number is:{smallestNumber}");


            numbers.Sort();

            Console.Write("The sorted list is:\n ");
                foreach (int number in numbers)
        {
            Console.Write($"{number}\n");
        }
        }   
    }
