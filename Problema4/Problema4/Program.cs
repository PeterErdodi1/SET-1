using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("An= ");
            year = int.Parse(Console.ReadLine());
            if ((year % 100 != 0 && year % 400 == 0) || year % 4 == 0)
            {
                Console.WriteLine("Acest an este bisect");
            }
            else
                Console.WriteLine("Acest an nu este an bisect");
        }
    }
}
