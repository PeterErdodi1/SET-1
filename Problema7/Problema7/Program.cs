using System;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("A= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("A= ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);

        }
    }
}
