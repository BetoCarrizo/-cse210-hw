public class DebitCard : acvCard
{
    public DebitCard(int PIN, int cardNumber) : base(PIN, cardNumber)
    {

    }

     public override int AcvGetMaxTransactions()
    {
        return base.AcvGetMaxTransactions();
    }
}