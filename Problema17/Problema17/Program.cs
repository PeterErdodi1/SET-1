using System;

namespace Problema17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, d=0,m;
            Console.Write("A= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = int.Parse(Console.ReadLine());
            if(a<b)
            {
                for(int i=1; i<=a; i++)
                    if(a%i==0 && b%i==0)
                    {
                        d = i;
                    }
            }
            else
            {
                for (int i = 1; i <= b; i++)
                    if (b % i == 0 && a%i==0)
                    {
                        d = i;
                    }
            }
            m = (a * b) / d;
            Console.WriteLine("Cel mai mare divizor comun >"+d);
            Console.WriteLine("Cel mai mic multiplu comun >"+m);
        }
    }
}
