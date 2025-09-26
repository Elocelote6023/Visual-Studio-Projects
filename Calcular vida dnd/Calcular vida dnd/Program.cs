using System;

namespace CalculadoraDeMonedas
{
    public class Program
    {
        private static long Dado;
        private static long Constitución;
        private static long Nivel;
        private static long VidaFinal = 0;
        private static long Multiclase = 1;
        private static long Tough = 0;

        public static void Main()
        {
            Console.WriteLine("Introduce tu numero de caras máximo del dado:");
            Dado = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduce tu bonificador de constitución:");
            Constitución = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduce tu nivel:");
            Nivel = Convert.ToInt64(Console.ReadLine());
            VidaFinal = VidaFinal + Dado + (((Dado / 2) + 1) * (Nivel - 1)) + (Constitución * Nivel);

            do
            {
                Console.WriteLine("¿Tienes otra clase? 0 para no, 1 para sí:");
                Multiclase = Convert.ToInt64(Console.ReadLine());

                if (Multiclase == 1)
                {
                    Console.WriteLine("Introduce tu numero de caras máximo del dado:");
                    Dado = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Introduce tu nivel:");
                    Nivel = Convert.ToInt64(Console.ReadLine());
                    VidaFinal = VidaFinal + (((Dado / 2) + 1) * Nivel) + (Constitución * Nivel);

                }
                else if (Multiclase != 0)
                {
                    Console.WriteLine("Respuesta inválida. Por favor, introduce 0 o 1.");
                }

            } while (Multiclase == 1);


            Console.WriteLine("¿Tienes tough como dote? 0 para no, 1 para sí:");

            do
            {

                Tough = Convert.ToInt64(Console.ReadLine());

                if (Tough == 0)
                {
                    Console.WriteLine(VidaFinal);
                }
                else if (Tough == 1)
                {
                    Console.WriteLine(VidaFinal + (Nivel * 2));
                }
                else
                {
                    Console.WriteLine("Respuesta inválida. Por favor, introduce 0 o 1.");
                }

            } while (Tough != 0 && Tough != 1);

        }
    }
}