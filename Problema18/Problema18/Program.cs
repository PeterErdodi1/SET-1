using System;

namespace Problema18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=2;

            Console.WriteLine("N=  ");
            n = int.Parse(Console.ReadLine());
            while(i<=n)
            {
                if(n%i==0)
                {
                    Console.Write("{0}*", i);
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
