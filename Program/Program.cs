using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            double s, t;
            Console.Write("s = ");
            s = double.Parse(Console.ReadLine());
            Console.Write("t = ");
            t = double.Parse(Console.ReadLine());

            double c = (F(1, t * t, s) + F(t, s * s, 1)) / (1 + Math.Pow(F(1, t * s, 1), 2));

            Console.WriteLine("c = " + c);
        }

        public static double F(double a, double b, double c)
        {
            return (Math.Sin(a * b * c) * Math.Sin(a * b * c) / (a * a + b * b + c * c));
        }
    }
}