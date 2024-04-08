public class acvCreditCard : acvCard
{
    public acvCreditCard(int PIN, int cardNumber) : base(PIN, cardNumber)
    {

    }

    public override int AcvGetMaxTransactions()
    {
        return 250;
    }
}