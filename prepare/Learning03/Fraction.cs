
public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {

        _top=1;
        _bottom=1;
    }
    public Fraction(int Wholenumber)
    {
        _top =Wholenumber;
        _bottom=1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetString()
    {
        string GetStrings= $"{_top}/{_bottom}";
        return  GetStrings;
    }
    public double GetResult()
    {
        double result = (double)_top / (double)_bottom;
        return result;




    }
}