using System;

namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, b;
            Console.Write("A= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("N= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Din intervalul ["+a+","+b+"] acest numere sunt divizibile cu n > ");
            while (a<=b)
            {
                if(n%a==0)
                {
                    Console.Write(a+" ");
                }
                a++;
            }
        }
    }
}
