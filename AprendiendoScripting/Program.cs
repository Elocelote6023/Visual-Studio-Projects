using System;

namespace EjercicioUno
{
    public class Program
    {

        //ejercicio uno
        private static decimal a;
        private static decimal b;
        private static double ab;

        private static float pi;
        private static char ch;
        private static string name;

        public static string Name { get => name; set => name = value; }

        //ejercicio dos

        public static int A;
        public static int B;
        public static Random Aleatorio = new Random();
        public static int CambioDeValores;

        //ejercicio tres

        private static long Coins;
        private static decimal Gp;
        private static decimal Sp;
        private static decimal Cp;
        public static long nGp;
        public static long nSp;
        public static long nCp;

        public static void Main(string[] args) 
        {
            Console.WriteLine("Ejercicio Uno:");
            Console.WriteLine("");
            Console.WriteLine("Introduzca un numero");

           

            a= Convert.ToDecimal (Console.ReadLine());

     

            Console.WriteLine("Introduzca un segundo numero");

           

            b = Convert.ToDecimal(Console.ReadLine());

            Division(a, b);


        }

        public static void Division( decimal num1, decimal num2)
        {
            ab = Decimal.ToDouble(a / b);

            

           Console.WriteLine("La division del primero con el segundo es: " + Math.Round(ab, 5));

            SegundaParte();
        
        }

        public static void SegundaParte() 
        {
            pi = 3.14f;

            Console.WriteLine("Introduce un nombre");

            Name = Console.ReadLine().ToLower().Trim();

            ch = name.ToUpper()[0];

            Name = ch + name.Substring(1);

            Console.WriteLine("El numero Pi es = " + pi + ";" + " Extraido por: " + ch + ". " + Name);
            Console.WriteLine("");

            EjercicioDos();

        }


        public static void EjercicioDos()
        {
            Console.WriteLine("Ejercicio Dos:");
            Console.WriteLine("");

            A = Aleatorio.Next(1, 20);
            B = Aleatorio.Next(1, 20);

            Console.WriteLine(A + " " + B);

            CambioDeValores = A;
            A = B;
            B = CambioDeValores;

            Console.WriteLine(A + " " + B);

            EjercicioTres();
        }

        public static void EjercicioTres() 
        {
            Console.WriteLine("Ejercicio Tres:");
            Console.WriteLine("");

            Console.WriteLine("Escribe la cantidad de monedas totales (en cobre)");

            Coins = Convert.ToInt64(Console.ReadLine());

            nGp = Coins / 100;
            nSp = (Coins / 10) - (nGp*10);
            nCp = Coins - (nSp*10) - (nGp*100);

            Gp = nGp;
            Sp = nSp;
            Cp = nCp;

            Console.WriteLine("");
            Console.WriteLine("Monedas // Cobre: " + Cp + " // Plata: " + Cp + " // Oro: " + Gp);
            Console.WriteLine("");
            Console.WriteLine("Escribe la cantidad de monedas totales a restar (en cobre)");
            Console.WriteLine("");

            Coins = Convert.ToInt64(Console.ReadLine());

            nGp = Coins / 100;
            nSp = (Coins / 10) - (nGp * 10);
            nCp = Coins - (nSp * 10) - (nGp * 100);

            Gp = Gp - nGp;
            Sp = Sp - nSp;
            Cp = Cp - nCp;

            Console.WriteLine("Monedas // Cobre: " + Cp + " // Plata: " + Cp + " // Oro: " + Gp);
            Console.WriteLine("");
            


        }

    }







}

