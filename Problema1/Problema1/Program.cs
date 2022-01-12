using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            
            Console.Write("A= ");
            a = Single.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = Single.Parse(Console.ReadLine());
            Console.WriteLine(a + "x+" + b + "=0");
            float n = b / a;
            Console.WriteLine("x=" + (float)n);
            
        }
    }
}
