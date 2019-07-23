using AreaCalcuator;
using System;

public class Circle: Shape
{
    private double radius;
    public static readonly double PI = 3.14;
	public Circle(double radius)
	{
        this.radius = radius;
	}

    public override double CalculateArea()
    {
        return PI * radius * radius;
    }
}
