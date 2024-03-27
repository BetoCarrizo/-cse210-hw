using System;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    
    {   Fraction acvFraction1 = new Fraction();
        Console.WriteLine(acvFraction1.GetString());
        Console.WriteLine(acvFraction1.GetResult());


        Fraction acvFraction2 = new Fraction(5);
        Console.WriteLine(acvFraction2.GetString());
        Console.WriteLine(acvFraction2.GetResult());



        Fraction acvFraction3 = new Fraction(5,6);
        Console.WriteLine(acvFraction3.GetString());
        Console.WriteLine(acvFraction3.GetResult());

    }


}


  




