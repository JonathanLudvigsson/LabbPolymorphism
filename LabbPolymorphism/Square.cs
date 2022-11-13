using System;

namespace LabbPolymorphism
{
    public class Square : Geometry
    {
        public override string Name { get { return "Fyrkant"; } }
        private double SideLength { get; set; }
        public Square()
        {
            SideLength = 8;
        }
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        public override double Area()
        {
            return Math.Round(SideLength * SideLength, 2);
        }
        public override double Circumference()
        {
            return Math.Round(SideLength * 4, 2);
        }
    }
}
