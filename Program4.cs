using System;

namespace o
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            for (letra = 'z'; letra >= 'a'; letra--)
                Console.WriteLine("{0}", letra);
        }
    }
}
