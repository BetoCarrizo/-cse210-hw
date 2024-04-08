using System.Runtime.InteropServices;

public class acvDisplays
{  
    private string acvChoice;
    
    public string choices
    {
        get
        {
            return acvChoice;
        }
        set
        {
            acvChoice = value;
        }
    }
    public void acvDisplayDebitOrCredit()
    {
        Console.WriteLine("Choose an option from the menu:");
        Console.WriteLine("1. Deposit...");
        Console.WriteLine("2. Withdraw...");
        Console.WriteLine("3. Show Balance...");
        Console.WriteLine("4. Log out...");
        Console.Write("Select an option from the menu: ");
        

            acvChoice = Console.ReadLine(); 
    }
    public void acvAskChoice()
    {
        string acvChoice = Console.ReadLine();
    }

    public string acvGetChoise()
    {
        return acvChoice;
    }



















}