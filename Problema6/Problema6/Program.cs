using System;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("A=");
            a = int.Parse(Console.ReadLine());
            Console.Write("B=");
            b = int.Parse(Console.ReadLine());
            Console.Write("C=");
            c = int.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Acest 3 numere pot fi lungimea unui triunghi");
            }
            else
                Console.WriteLine("Acest 3 numere nu pot fi lungimea unui triunghi");
        }
    }
}
