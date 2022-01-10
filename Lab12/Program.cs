using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.Length(1));
            Console.WriteLine(Circle.Square(1));
            Console.WriteLine(Circle.Dot(0, 0, 1, 0, 0));
            Console.WriteLine(Circle.Dot(0, 0, 1, 1 ,1));
            Console.ReadKey();
            
        }
    }
    // или класс в формате dll нужен?
    public static class Circle
    {
        public static double r;
        public static double Length(double r)
        {
            return (2 * Math.PI * r);
        }

        public static double Square(double r)
        {
            return (Math.PI * r * r);
        }

        public static bool Dot(int x, int y, double r, int x0, int y0)
        {
            if ((Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0))) <= r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
