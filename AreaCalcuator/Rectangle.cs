using AreaCalcuator;
using System;

public class Rectangle: Shape
{
    private double length;
    private double breadth;
	public Rectangle(double length, double breadth)
	{
        this.length = length;
        this.breadth = breadth;
	}

    public override double CalculateArea()
    {
        return length * breadth;
    }
}
