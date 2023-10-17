using System;

namespace _01_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Areaparallelogram();
        }

        static void AreaTrapezoid()
        {
            Console.Write("Enter first Base :");
            var f_base = Double.Parse(Console.ReadLine());

            Console.Write("Enter seconed Base :");
            var s_base = Double.Parse(Console.ReadLine());

            Console.Write("Enter Hight :");
            var hight = Double.Parse(Console.ReadLine());

            var area = (0.5 * (f_base + s_base) * hight);

            Console.WriteLine($"Area = (0.5 * ({f_base} + {s_base} ) * {hight} )  = {area}  ");
        }

        static void Areaparallelogram()
        {
            Console.Write("Enter First Diameter :");
            var f_base = Double.Parse(Console.ReadLine());

            Console.Write("Enter Seconed Diameter :");
            var s_base = Double.Parse(Console.ReadLine());

      

            var area = (f_base * s_base) /2;

            Console.WriteLine($"Area =  ({f_base} * {s_base} ) *  / 2  = {area}  ");
        }


    }
}
