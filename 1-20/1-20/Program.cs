using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<int> mayores15No20 = new List<int>();
        List<int> iguales20 = new List<int>();

        for (int i = 0; i < 60; i++)
        {
            int numero = random.Next(1, 21);

            if (numero >= 15 && numero < 20)
            {
                mayores15No20.Add(numero);
            }
            else if (numero == 20)
            {
                iguales20.Add(numero);
            }
        }

        Console.WriteLine("Cantidad de números mayores que 15 pero no iguales a 20: " + mayores15No20.Count);
        Console.WriteLine("Números: " + string.Join(", ", mayores15No20));
        Console.WriteLine("Cantidad de números iguales a 20: " + iguales20.Count);
        Console.WriteLine("Números: " + string.Join(", ", iguales20));
    }
}