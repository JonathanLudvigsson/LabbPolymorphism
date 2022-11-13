using System;

namespace LabbPolymorphism
{
    public class Circle : Geometry
    {
        public override string Name { get { return "Cirkel"; } }
        private double Radius { get; set; }
        public Circle()
        {
            Radius = 6;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }
        public override double Circumference()
        {
            return Math.Round(Radius * 2 * Math.PI, 2); 
        }
    }
}
