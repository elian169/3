using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, resultado, numero;
            suma = 0;
            resultado = 0;
            Console.WriteLine("escribe un numero");
            numero = int.Parse(Console.ReadLine());
            resultado = numero;
            while (numero != 0)
            {
                Console.WriteLine("Digite otro número");
                numero = int.Parse(Console.ReadLine());
                suma++;
                resultado +=numero;
            }
            Console.WriteLine("La cantidad de numeros digitados es: " + suma);
            Console.WriteLine("La suma de todos los numeros es: " + resultado);
            Console.ReadKey();

        }
    }
}
