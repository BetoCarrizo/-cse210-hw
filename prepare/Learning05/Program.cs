using System;
using System.ComponentModel;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {   
        acvSquare S = new acvSquare ();
        S.SetSide(5);
        S.SetColor("Red");
        DisplayArea(S);


        acvRectangle R = new acvRectangle();
        R.SetLength(7);
        R.SetWidth(4);
        R.SetColor("Blue");
        DisplayArea(R);

        acvCircle C = new acvCircle();
        C.SetRadius(8);
        C.SetColor("pink");
        DisplayArea(C);

        List<acvShape> Shap = new List<acvShape>();
        Shap.Add(S);
        Shap.Add(R);
        Shap.Add(C);
            foreach (acvShape shape in Shap)
            {
                double Area= shape.GetArea();
            }

    }
    public static void DisplayArea(acvShape Shapes)
    {
        double area = Shapes.GetArea();
        string color =Shapes.GetColor();
        Console.WriteLine($"The color is: {color}" );
        Console.WriteLine($"The Area is: {area:f2}");
    }
}

