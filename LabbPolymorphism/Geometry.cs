using System;
using System.Collections.Generic;
using System.Text;

namespace LabbPolymorphism
{
    public class Geometry
    {
        public virtual string Name { get { return "null"; } }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Circumference()
        {
            return 0;
        }
        public static void StartGeometry()
        {
            List<Geometry> shapes = new List<Geometry>
            {
                new Circle(),
                new Square(),
                new Rectangle()
            };
            foreach (Geometry shape in shapes)
            {
                Console.WriteLine($"{shape.Name} Area: {shape.Area()}\n{shape.Name} Omkrets: {shape.Circumference()}");
                Console.WriteLine();
            }
            Console.WriteLine("Vill du testa att räkna ut omkrets eller area med dina egna värden?");
            if (Console.ReadLine().ToLower() == "ja")
            {
                Console.Clear();
                UserGeometry();
            }
        }
        public static void UserGeometry()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hej! Vilken form vill du räkna ut omkrets eller area på? \nDu kan välja mellan Cirkel, Fyrkant eller Rektangel");

                Geometry g;
                bool error;
                do
                {
                    error = false;
                    switch (Console.ReadLine().ToLower())
                    {
                        case "cirkel":
                            Console.WriteLine("Skriv in radien på din cirkel");
                            g = new Circle(Double.Parse(Console.ReadLine()));
                            Console.WriteLine($"Area: {g.Area()}\nOmkrets: {g.Circumference()}");
                            Console.ReadKey(true);
                            break;
                        case "fyrkant":
                            Console.WriteLine("Skriv in längden på sidan av din fyrkant");
                            g = new Square(Double.Parse(Console.ReadLine()));
                            Console.WriteLine($"Area: {g.Area()}\nOmkrets: {g.Circumference()}");
                            Console.ReadKey(true);
                            break;
                        case "rektangel":
                            Console.WriteLine("Skriv in bredden och sedan höjden av din rektangel");
                            g = new Rectangle(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
                            Console.WriteLine($"Area: {g.Area()}\nOmkrets: {g.Circumference()}");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("Skriv in en giltig form");
                            Console.ReadKey(true);
                            Console.Clear();
                            error = true;
                            break;
                    }
                } while (error != true);

            }
        }
    }
}
