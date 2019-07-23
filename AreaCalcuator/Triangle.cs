using AreaCalcuator;
using System;

public class Triangle: Shape
{
    private double _base;
    private double height;
	public Triangle(double _base, double height)
	{
        this._base = _base;
        this.height = height;
	}


    public override double CalculateArea()
    {
        return 0.5 * _base * height;
    }
}
