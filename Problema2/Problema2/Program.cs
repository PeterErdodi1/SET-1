using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x,x1;
            Console.Write("a=");
            a =int.Parse(Console.ReadLine());
            Console.Write("b=");
            b =int.Parse(Console.ReadLine());
            Console.Write("c=");
            c =int.Parse(Console.ReadLine());
            Console.WriteLine(a + "(x^2)+" + b + "x+" + c + "=0");
            x = (b * b) - (4 * a * c);
            if (x > 0)
            {
                x = Math.Sqrt(x);
                x1 = ((-b) + x) / (2 * a);
                Console.WriteLine("x1= " + x1);
                x1 = ((-b) - x) / (2 * a);
                Console.WriteLine("x2= " + x1);
            }
            else
            {
                Console.WriteLine("Invalid.....");
            }


        }
    }
}
