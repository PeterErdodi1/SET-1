using System;

namespace Problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, i = 0;
            Console.Write("Year1 > ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Year2 > ");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            while (y1 <= y2)
            {
                if ((y1 % 100 != 0 && y1 % 4 == 0) || y1 % 400 == 0)
                {
                    Console.Write(y1+" ");
                    i++;
                }
                y1++;
            }
            Console.WriteLine("");
            Console.WriteLine("Bisecte intre y1 si y2>  " + i);
        }

    }
}
