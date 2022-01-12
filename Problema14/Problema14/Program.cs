using System;

namespace Problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k=0, i,rev;
            Console.Write("n=  ");
            n = int.Parse(Console.ReadLine());
            rev = n;
            while(n!=0)
            {
                i = n % 10;
                k = (k * 10) + i;
                n = n / 10;
            }
            if(rev==k)
            {
                Console.WriteLine("Acest numar este palindrom > "+rev);
            }
            else
            {
                Console.WriteLine("Acest numar nu este palindrom > "+rev);
            }
        }
    }
}
