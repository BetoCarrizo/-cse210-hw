public class acvCard : acvOptions
{
    private int _PIN=1234567890;
    private int _cardNumber=9393;

    public acvCard(int PIN, int cardNumber)
    {
        _PIN = PIN;
        _cardNumber = cardNumber;
    }

    public bool acvAuthorizeUser(int cardNumber, int PIN)
    {
        if (_cardNumber == cardNumber && _PIN == PIN)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Your information does not match");
            return false;
        }
    }

     public virtual int AcvGetMaxTransactions()
    {
        return 0;
    }
}