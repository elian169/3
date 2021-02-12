using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, impar = 0, par = 0;
            for (i = 100; i < 120; i++)
                if (i % 2 == 0)
                    Console.Write("{0}|", i);

            Console.Write("\n\n");


            Console.Read();
        }
    }
}
