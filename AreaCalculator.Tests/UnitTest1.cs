using System;
using AreaCalculator;
using Xunit;

namespace AreaCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircleArea()
        {
            double radius = 5;
            Circle circleObj = new Circle(radius);
            Assert.Equal(78.5, circleObj.CalculateArea());
        }


        [Fact]
        public void TestSquareArea()
        {
            double side = 6;
            Square squareObj = new Square(side);
            Assert.Equal(36, squareObj.CalculateArea());
        }


        [Fact]
        public void TestRectangleArea()
        {
            double length = 5, breadth = 2;
            Rectangle rectangleObj = new Rectangle(length, breadth);
            Assert.Equal(10, rectangleObj.CalculateArea());
        }


        [Fact]
        public void TestTriangleArea()
        {
            double _base = 5, height = 3;
            Triangle triangleObj = new Triangle(_base, height);
            Assert.Equal(7.5, triangleObj.CalculateArea());
        }
    }
}
