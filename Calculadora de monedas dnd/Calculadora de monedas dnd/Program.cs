using System.Drawing;

namespace CalculadoraDeMonedas
{
    public class Program
    {
        private static long Coins;
        private static decimal Gp;
        private static decimal Sp;
        private static decimal Cp;
        public static long nGp;
        public static long nSp;
        public static long nCp;

        public static void Main()
        {
            Console.WriteLine("Calculadora de monedas D&D:");
            Console.WriteLine("");

            Console.WriteLine("Escribe la cantidad de monedas de Oro que tengas");
            Console.WriteLine("");

            nGp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas de Plata que tengas");
            Console.WriteLine("");

            nSp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas de Cobre que tengas");
            Console.WriteLine("");

            nCp = Convert.ToInt64(Console.ReadLine());

            Coins = nGp * 100 + nSp * 10 + nCp;

            Gp = Coins / 100;
            Sp = (Coins / 10) - (Gp * 10);
            Cp = Coins - (Sp * 10) - (Gp * 100);

            Console.WriteLine("");
            Console.WriteLine("Tu total de monedas es:");
            Console.WriteLine("");
            Console.WriteLine("Cobre: " + Cp + " // Plata: " + Sp + " // Oro: " + Gp);
            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas que quieras restar de Oro");
            Console.WriteLine("");

            nGp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas que quieras restar de Plata");
            Console.WriteLine("");

            nSp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas que quieras restar de Cobre");
            Console.WriteLine("");

            nCp = Convert.ToInt64(Console.ReadLine());

            Coins = nGp * 100 + nSp * 10 + nCp;

            nGp = Coins / 100;
            nSp = (Coins / 10) - (nGp * 10);
            nCp = Coins - (nSp * 10) - (nGp * 100);

            Gp = Gp - nGp;
            Sp = Sp - nSp;
            Cp = Cp - nCp;

            if (Gp < 0)
            {
                while (Sp < 0)
                {
                    Gp = Gp - 1;
                    Sp = Sp + 10;
                }

                while (Cp < 0)
                {
                    Sp = Sp-1;
                    Cp = Cp+10;
                }
            }



            Console.WriteLine("Monedas // Cobre: " + Cp + " // Plata: " + Sp + " // Oro: " + Gp);
            Console.WriteLine("");
            Console.WriteLine("Escriba cualquier cosa para salir");
            Console.ReadLine();

        }



    }


}