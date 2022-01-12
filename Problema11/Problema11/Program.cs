using System;

namespace Problema11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k=0, i;
            Console.WriteLine("N=");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                i = n % 10;
                k = (k*10)+i;
                n = n / 10;
                
            }
            Console.Write("N= "+ k);
        }
    }
}
