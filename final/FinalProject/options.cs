using System.Data;
using System.Dynamic;

public class acvOptions
{   private string acvCreditOrDebit;
    CardHolder Carrizo = null;
    acvDisplays D = new acvDisplays();
    acvAnimation A = new acvAnimation();

    private string AcvCreditOrDebit
    {
        get
        {
            return acvCreditOrDebit;
        }
        set
        {
            acvCreditOrDebit = value;
        }
    }
    public void SetAcvCreditOrDebit()
    {
        Console.WriteLine("Please, especified wich account you want to acces...");
        Console.WriteLine("");
        Console.WriteLine("DEBIT CARD / CREDIT CARD");
        string acvCreditOrDebit = Console.ReadLine();
        Console.WriteLine("");

    }
    public string GetacvCreditOrDebit()
    {
        return acvCreditOrDebit;
    }
    public void AcvOptionDebitCredit()
    {
        if (acvCreditOrDebit == "debit" || acvCreditOrDebit == "Debit" || acvCreditOrDebit == "DEBIT" || acvCreditOrDebit == "d" || acvCreditOrDebit == "D")
        {
            acvCreditOrDebit = "Debit";
            DebitCard card = new DebitCard(9393, 1234567890);
                Carrizo = new CardHolder(100, card);
        }
    }
    public void acvDepositDataDebit(CardHolder holder)

    
    {
        Console.Write("Insert your Debit Card number: ");
        int cardNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert your PIN number: ");
        int PIN = int.Parse(Console.ReadLine());
        Console.Write("How much would you deposit? ");
        int amount = int.Parse(Console.ReadLine());

         if (holder.Card.acvAuthorizeUser(cardNumber, PIN))
        {
            holder.acvDeposit(cardNumber, PIN, amount);
            Console.Clear();
        }
        else
        {
            A.AcvAnimation();
            Console.Clear();
        }
    }
    
    public void acvWithdrawDataDebit(CardHolder holder)
    {
        Console.Write($"Insert your {acvCreditOrDebit} Card number: ");
        int cardNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert your PIN number: ");
        int PIN = int.Parse(Console.ReadLine());
        Console.Write("How much would you withdraw? ");
        int amount = int.Parse(Console.ReadLine());

       if (holder.Card.acvAuthorizeUser(cardNumber, PIN))
    {
        holder.acvWithdraw(cardNumber, PIN, amount);
        Console.Clear();
    }
    else
    {
        A.AcvAnimation();
        Console.Clear();
    }
    }
    
    public void AcvOptionCredit(CardHolder holder)
        {
                if (acvCreditOrDebit == "credit" || acvCreditOrDebit == "c" || acvCreditOrDebit == "Credit" || acvCreditOrDebit == "C" || acvCreditOrDebit == "CREDIT")
            {
                acvCreditOrDebit = "Credit";
                acvCreditCard card = new acvCreditCard(9393, 1234567890);
                Carrizo = new CardHolder(500, card);
            }
        }
    public void acvDepositDataCredit(CardHolder holder)
        {
            Console.Write("Insert your Credit Card number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.Write("Insert your PIN number: ");
            int PIN = int.Parse(Console.ReadLine());
            Console.Write("Hom much would you deposit? ");
            int ammount = int.Parse(Console.ReadLine());

            if (holder.Card.acvAuthorizeUser(cardNumber, PIN))
        {
            holder.acvDeposit(cardNumber, PIN, ammount);
            Console.Clear();
        }
        else
        {
            A.AcvAnimation();
            Console.Clear();
        }
        }
    public void acvWithdrawDataCredit(CardHolder holder)
        {
            Console.Write($"Insert your {acvCreditOrDebit} Card number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.Write("Insert your PIN number: ");
            int PIN = int.Parse(Console.ReadLine());

            Console.Write("The user can withdraw more money because of his credit history... ");
            Console.WriteLine("Credit money: " + 250);
            Console.WriteLine("How much will you withdraw from your card? ");
            int ammount = int.Parse(Console.ReadLine());



            if (holder.Card.acvAuthorizeUser(cardNumber, PIN))
                {
                holder.acvWithdraw(cardNumber, PIN, ammount);
                Console.Clear();
                }

            else
                {
                A.AcvAnimation();
                Console.Clear();
                }
        }
        public void acvBalance(CardHolder holder)
        {
            Console.Write($"Insert your {acvCreditOrDebit} Card number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.Write("Insert your PIN number: ");
            int PIN = int.Parse(Console.ReadLine());

             if (holder.Card.acvAuthorizeUser(cardNumber, PIN))
                {
                holder.acvShowBalance(cardNumber, PIN);
                A.AcvAnimation();
                Console.Clear();
                }

            else
                {
                A.AcvAnimation();
                Console.Clear();
                }

        }

}