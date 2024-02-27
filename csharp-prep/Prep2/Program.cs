using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the number porcentage ");
        string port= Console.ReadLine();
        int number = int.Parse(port);

            string letter= "";
            string sig="";

            


            if (number >=90)
            {letter= "A";
            }
            else if (number >=80)
            {letter= "B";
            }
            else if (number >=70)
            {letter= "C";
            }
            else if (number >=60)
            {letter= "D";
            }
            else 
            {letter= "F";
            }

            
            int LastD = number % 10;


            if (number>93)
            { sig= "";}

            else if (LastD <3)
            { sig="-";}

             else if (LastD>=7)
            {sig="+";}

            if (number<60)
            {sig="";}


          
           
            

            Console.WriteLine($"Your grade is: {sig+letter}");

    if (number>69.9999)
        {Console.WriteLine ("Congratulations!, You pass the Class.");}
    else
        {Console.WriteLine("Sorry you have fail, try next time!!");}
    
    }
}