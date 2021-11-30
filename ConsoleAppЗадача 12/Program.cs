using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.Circumference(5));
            Console.WriteLine(Circle.Area(5));
            Console.WriteLine(Circle.LiesWithinCircle(3, 3, 5, 2, 2));
            Console.WriteLine(Circle.LiesWithinCircle(3, 3, 1, 1, 1));
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double Circumference(double rad)
        {
            return Math.Round((2 * Math.PI * rad), 2);
        }
        public static double Area(double rad)
        {
            return Math.Round(Math.PI * Math.Pow(rad, 2), 2);
        }
        public static bool LiesWithinCircle(int x, int y, double r, int x0, int y0)
        {
            if (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) <= Math.Pow(r, 2))
            {
                return true;
            }
            return false;
            
        }
    }
    
}
