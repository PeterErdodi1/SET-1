using System;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("N=  ");
            n = int.Parse(Console.ReadLine());
            Console.Write("N se divide cu > ");
            for (i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    Console.Write(i + " ");
                }
            }


        }
    }
}
