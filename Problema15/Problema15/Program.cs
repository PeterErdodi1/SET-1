using System;

namespace Problema15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[4];
            int i,s,j;
            for(i=1; i<=3; i++)
            {
                n[i]=int.Parse(Console.ReadLine());
            }
            if(n[1]>n[2])
            {
                s = n[1];
                n[1] = n[2];
                n[2] = s;
            }
            if(n[1]>n[3])
            {
                s = n[1];
                n[1] = n[3];
                n[3] = s;
            }
            if(n[2]>n[3])
            {
                s = n[2];
                n[2] = n[3];
                n[3] = s;
            }


            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine(n[i]);
            }

        }
    }
}
