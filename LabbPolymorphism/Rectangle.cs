using System;

namespace LabbPolymorphism
{
    public class Rectangle : Geometry
    {
        public override string Name { get { return "Rektangel"; } }
        private double Width { get; set; }
        private double Height { get; set; }
        public Rectangle()
        {
            Width = 4;
            Height = 12;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Math.Round(Width * Height, 2);
        }
        public override double Circumference()
        {
            return Math.Round(Width * 2 + Height * 2, 2);
        }
    }
}
