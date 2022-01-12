using System;

namespace Problema19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=0,ok1=0,ok2=0,ok3=0,k=0;
            int[] v= new int [10];
            Console.WriteLine("N= ");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                v[i] = n % 10;
                n = n / 10;
                k++;
            }
            ok1 = v[0];
            ok2 = 0;
            Console.WriteLine(ok1);
            for (i=0; i<k; i++)
            {
                if(v[i]==ok1)
                {
                    
                    ok2 =ok2+1;
                }
                
            }
            
            Console.WriteLine(ok2);
            while (v[i]!=ok1)
            {
                if(v[i]!=ok1)
                {
                    ok3 = v[i];
                    break;
                }
                break;
            }

            Console.WriteLine(ok3);
            ok1 = 0;
            for (i = 0; i < k; i++)
            {
                if (v[i] == ok3)
                {
                    ok1++;
                }

            }
            Console.WriteLine(ok1);
            ok1 = ok1 + ok2;
            Console.WriteLine(ok1+" "+k);
            if (ok1==k)
             {
                 Console.WriteLine("Acest numar  este format doar din 2 cifre >");
             }
             else
             {
                 Console.WriteLine("Acest numar nu este format doar din 2 cifre >");
             }    

             
        }
    }
}
