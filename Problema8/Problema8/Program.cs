using System;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("A= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);
        }
    }
}
