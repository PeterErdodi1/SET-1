using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            if(n%k==0)
            {
                Console.WriteLine("N se divide cu k");
            }
            else
            {
                Console.WriteLine("N nu se divide cu k");
            }
        }
    }
}
