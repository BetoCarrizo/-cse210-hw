using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        acvAnimation A = new acvAnimation();
        acvOptions O = new acvOptions();
        acvDisplays D = new acvDisplays();
        acvCard card = new DebitCard(9393, 1234567890);
        CardHolder Carrizo = new CardHolder(100, card);
        
                                                                                                                                                                                                                                                                                           

        // The card number is: 1234567890
        // The PIN is: 9393
        // for both cards the info is the same
    
                                             

       
        Console.Clear();    
        Console.WriteLine("Welcome to your personal ATM!");
        A.AcvAnimation();

        Console.Clear();

        O.SetAcvCreditOrDebit();
                
        Console.Clear();
       bool exit = false;
while (!exit)
{
    O.AcvOptionDebitCredit();

    while (true)
    {
        D.acvDisplayDebitOrCredit();
        // D.acvAskChoice();

        A.AcvAnimation();

        string acvChoice = D.acvGetChoise();

        Console.Clear();

        if (D.acvGetChoise() == "1")
        {
            O.acvDepositDataDebit(Carrizo);
            Console.Clear();
        }

        if (acvChoice == "2")
        {
            O.acvWithdrawDataDebit(Carrizo);

        }

        if (acvChoice == "3")
        {
            Carrizo.acvBalance(Carrizo);
            Console.WriteLine("");

        }

        if (acvChoice == "4")
        {
            Console.WriteLine("Thanks for choosing personal ATM. Good Bye :))");
            A.AcvAnimation();
            Console.Clear();
            exit = true;
            break;
        }

    }

    if (!exit)
    {
        O.AcvOptionCredit(Carrizo);

        while (true)
        {
            D.acvDisplayDebitOrCredit();

            A.AcvAnimation();

            string choice = D.acvGetChoise();

            Console.Clear();

            if (choice == "1")
            {
                O.acvDepositDataCredit(Carrizo);

            }

            if (choice == "2")
            {
                O.acvWithdrawDataCredit(Carrizo);

            }

            if (choice == "3")
            {

                Carrizo.acvBalance(Carrizo);
                Console.WriteLine("");
            }

            if (choice == "4")
            {
                Console.WriteLine("Thanks for choosing personal ATM. Good Bye :))");
                A.AcvAnimation();
                Console.Clear();
                exit = true;
                break;
            }
        }
    }
}

if (Carrizo == null)
{
    Console.WriteLine("Invalid option");
    return; // exit the program
}
    }
}