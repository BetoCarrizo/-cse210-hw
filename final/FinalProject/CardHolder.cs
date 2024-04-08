
public class CardHolder : acvOptions
{
    
    private int _balance;
    private acvCard _card;

    public int Balance { get { return _balance; } }
    public acvCard Card { get { return _card; } }

    public CardHolder(int balance, acvCard card)
    {
        _balance = balance;
        _card = card;
    }

    public int acvGetBalance()
    {
        return _balance;
    }

    public void acvDeposit(int cardNumber, int PIN, int amount)
    {
        if (_card.acvAuthorizeUser(cardNumber, PIN))
        {
            _balance += amount;
        }
    }

    public void acvWithdraw(int cardNumber, int PIN, int amount)
    {
        if (_card.acvAuthorizeUser(cardNumber, PIN))
        {
            if (_card is acvCreditCard)
            {
                _balance += ((acvCreditCard)_card).AcvGetMaxTransactions();
            }
            _balance -= amount;
        }
    }

    public void acvShowBalance(int cardNumber, int PIN)
    {
        
        
            int totalBalance = _balance;

            if (_card is acvCreditCard)
            {
                totalBalance += ((acvCreditCard)_card).AcvGetMaxTransactions();
            }

            Console.WriteLine($"Your balance: {totalBalance}");
        }
          
         
    }

