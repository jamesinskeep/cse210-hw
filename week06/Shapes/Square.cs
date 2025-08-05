using System.Drawing;

public class Square : Shape
{
    private double _side;
    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
    public Square(string color, double side)
    {
        _side = side;
        _color = color;
    }
}