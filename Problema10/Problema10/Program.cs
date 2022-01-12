using System;

namespace Problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=0,i;
            Console.Write("N= ");
            n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    k++;
                }    
            }

            if(k==2)
            {
                Console.WriteLine("N un este numar prim");
            }
            else
            {
                Console.WriteLine("N nu un este numar prim");
            }
        }
    }
}
