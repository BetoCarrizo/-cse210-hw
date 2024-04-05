using System.Numerics;

public class acvRectangle:acvShape
{   private double _Length;
    private double _Width;

    public double GetLength(int v)
    {
        return _Length;
    }
    public double GetWidth ()
    {
        return _Width;
    }
    public void SetLength(double Length)
    {
        _Length = Length;
    }
    public void SetWidth (double Width) 
    {
        _Width = Width;
    }

    public override double GetArea()
    {
        return _Length*_Width;
    }
}






