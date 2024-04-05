
public class acvCircle:acvShape
{   private double _Radius;
    

    public double GetRadius()
    {
        return _Radius;
    }
    
    public void SetRadius(double Radius)
    {
        _Radius = Radius;
    }
    

    public override double GetArea()
    {
        return (_Radius*_Radius*Math.PI);
    }
}


