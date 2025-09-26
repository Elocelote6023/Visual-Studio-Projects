using CreadorDeCoches;
using System;
using System.Data;
using System.Drawing;
namespace CreadorDeCoches
{
    enum TipoDeMotor { Gasolina = 1, Diesel = 2, Hibrido = 3, Electrico = 4 }
    enum TipoDeTraccion { Delantera = 1, Trasera = 2, Total = 3 }
    public class Program
    {

        public static int NumeroCoches;
        public static int NumeroMotos;
        public static int NumeroCamiones;
        public static string Confirmacion;
        private static List<Coche> listaDeCoches = new List<Coche>();
        private static List<Moto> listaDeMotos = new List<Moto>();
        private static List<Camion> listaDeCamiones = new List<Camion>();

        private static List<Coche> ListaDeCoches { get => listaDeCoches; set => listaDeCoches = value; }
        private static List<Moto> ListaDeMotos { get => listaDeMotos; set => listaDeMotos = value; }
        private static List<Camion> ListaDeCamiones { get => listaDeCamiones; set => listaDeCamiones = value; }

        public static void Main(string[] args)
        {
        VolverAPreguntarNCoches:
            Console.WriteLine("Seleccione el número de Coches");


            if (int.TryParse(Console.ReadLine().Trim(), out NumeroCoches))
            {

            }
            else
            {
                Console.WriteLine("No has introducido un número");
                goto VolverAPreguntarNCoches;
            }

            if (NumeroCoches <= 0) { NumeroCoches = -NumeroCoches; };

        ConfirmarNCoches:
            Console.WriteLine("");
            Console.WriteLine("El numero de coches que tienes es " + NumeroCoches + " ¿Es correcto?");

            Confirmacion = Console.ReadLine().ToLower().Trim();

            switch (Confirmacion)
            {
                case "si":
                case "sí":
                case "s":
                case "yes":
                case "ye":
                case "y":
                    Console.WriteLine("");
                    Console.WriteLine("Perfecto");
                    break;

                case "no":
                case "n":
                    Console.WriteLine("");
                    goto VolverAPreguntarNCoches;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Introduce una confirmación válida (Si o No)");
                    goto ConfirmarNCoches;

            }

            string ModeloCoche;
            float PotenciaCoche;
            string MatriculaCoche;
            int RuedasCoche = 4;
            TipoDeMotor TipoMotorCoche;
            string CambioDeMarchasCoche;
            TipoDeTraccion TipoDeTracciónCoche;
            int NumeroPuertasCoche;
            bool VehiculoEspecialCoche;
            bool ServicioPublicoCoche;
            bool TintarVentanillasTraserasCoche;

            SiguienteCoche:
            if (NumeroCoches != 0)
            {
                Console.WriteLine("Cual es el modelo del coche número " + NumeroCoches);
                ModeloCoche = Console.ReadLine().Trim().ToLower();

                PreguntarPotenciaDeCoche:
                Console.WriteLine("Cual es la potencia (Caballos) del coche número" + NumeroCoches);
                if (float.TryParse(Console.ReadLine().Trim(), out PotenciaCoche))
                {

                }
                else
                {
                    Console.WriteLine("No has introducido un número");
                    goto PreguntarPotenciaDeCoche;
                }

                Console.WriteLine("Se ha generado una matricula para el coche " + NumeroCoches + " aleatoriamente");
                Random random = new Random();
                char letter1 = (char)random.Next('A', 'Z' + 1);
                char letter2 = (char)random.Next('A', 'Z' + 1);
                char letter3 = (char)random.Next('A', 'Z' + 1);
                int num1 = random.Next(0, 10);
                int num2 = random.Next(0, 10);
                int num3 = random.Next(0, 10);
                int num4 = random.Next(0, 10);
                num1 = num1 * 1000;
                num2 = num2 * 100;
                num3 = num3 * 10;
                MatriculaCoche = num1 + num2 + num3 + num4 + " " + letter1 + letter2 + letter3;
                Console.WriteLine(MatriculaCoche);

                Console.WriteLine("El numero de ruedas del coche " + NumeroCoches + " debe de ser 4");
                Console.WriteLine(RuedasCoche);

                Console.WriteLine("Seleccione el tipo de motor del coche " + NumeroCoches);
                PreguntarMotorDeCoche:
                Console.WriteLine("Escriba 1 2 3 o 4 para elegir Gasolina, Diesel, Hibrido o Electrico respectivamente");
                int input;
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1)
                {
                    Console.WriteLine("Su coche tiene un motor de " + TipoDeMotor.Gasolina);
                    TipoMotorCoche = TipoDeMotor.Gasolina;
                    goto FinDeMotor;
                }
                if (input == 2)
                {
                    Console.WriteLine("Su coche tiene un motor " + TipoDeMotor.Diesel);
                    TipoMotorCoche = TipoDeMotor.Diesel;
                    goto FinDeMotor;
                }
                if (input == 3)
                {
                    Console.WriteLine("Su coche tiene un motor " + TipoDeMotor.Hibrido);
                    TipoMotorCoche = TipoDeMotor.Hibrido;
                    goto FinDeMotor;
                }
                if (input == 4)
                {
                    Console.WriteLine("Su coche tiene un motor " + TipoDeMotor.Electrico);
                    TipoMotorCoche = TipoDeMotor.Electrico;
                    goto FinDeMotor;
                }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarMotorDeCoche;
                }
            FinDeMotor:


                Console.WriteLine("Escriba el típo de cambio de marchas del coche " + NumeroCoches + " (Automático o Manual)");
            PreguntarMarchasDeCoche:
                CambioDeMarchasCoche = Console.ReadLine().ToLower().Trim();
                switch (CambioDeMarchasCoche)
                {
                    case "automatico":
                    case "automático":
                    case "automatic":
                    case "automátic":
                    case "auto":
                    case "a":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasCoche = "Automático";
                        break;

                    case "manual":
                    case "emanuel":
                    case "emmanuel":
                    case "emannuel":
                    case "emmannuel":
                    case "m":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasCoche = "Manual";
                        break;

                    default:
                        Console.WriteLine("Debe escribir Automático o Manual (Puede escribir 'A' o 'M' en su lugar)");
                        goto PreguntarMarchasDeCoche;
                }

                Console.WriteLine("Seleccione el tipo de tracción del coche " + NumeroCoches);
                PreguntarTraccionDeCoche:
                Console.WriteLine("Escriba 1 2 o 3 para elegir Delantera, Trasera o Total respectivamente");
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1) { Console.WriteLine("Su coche es de tracción " + TipoDeTraccion.Delantera); TipoDeTracciónCoche = TipoDeTraccion.Delantera; }
                else if (input == 2) { Console.WriteLine("Su coche es de tracción " + TipoDeTraccion.Trasera); TipoDeTracciónCoche = TipoDeTraccion.Trasera; }
                else if (input == 3) { Console.WriteLine("Su coche es de tracción " + TipoDeTraccion.Total); TipoDeTracciónCoche = TipoDeTraccion.Total; }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarTraccionDeCoche;
                }
                

                Console.WriteLine("Elija el número de puertas del coche " + NumeroCoches + " (3 o 5)");
                PreguntarPuertasDeCoche:
                int.TryParse(Console.ReadLine().Trim(), out NumeroPuertasCoche);
                if (NumeroPuertasCoche == 3) { Console.WriteLine("Su coche tiene " + NumeroPuertasCoche + " Puertas"); }
                else if (NumeroPuertasCoche == 5) { Console.WriteLine("Su coche tiene " + NumeroPuertasCoche + " Puertas"); }
                else
                {
                    Console.WriteLine("Su coche debe tener bien 3 o bien 5 puertas");
                    goto PreguntarPuertasDeCoche;
                }


                PreguntarVehiculoEspecialCoche:
                Console.WriteLine("¿Es su coche un vehiculo especial? Escriba true o false");
                if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out VehiculoEspecialCoche)) { }
                else { goto PreguntarVehiculoEspecialCoche; }

                PreguntarServicioPublicoCoche:
                Console.WriteLine("¿Es su coche de servicio público? Escriba true o false");
                if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out ServicioPublicoCoche)) { }
                else { goto PreguntarServicioPublicoCoche; }

                PreguntarTintarVentanillasCoche:
                Console.WriteLine("¿Quiere tintar las ventanillas traseras?  Escriba true o false");
                if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out TintarVentanillasTraserasCoche)) { }
                else { goto PreguntarTintarVentanillasCoche; }

                Coche coche = new Coche(ModeloCoche, PotenciaCoche, MatriculaCoche, RuedasCoche, TipoMotorCoche, CambioDeMarchasCoche, TipoDeTracciónCoche, NumeroPuertasCoche, VehiculoEspecialCoche, ServicioPublicoCoche, TintarVentanillasTraserasCoche);

                ListaDeCoches.Add(coche);

                NumeroCoches = NumeroCoches - 1;
                goto SiguienteCoche;
            }
            else
            {
                Console.WriteLine("Coches finalizados");
            }

            foreach (Coche coche in ListaDeCoches)
            {
                Console.WriteLine(coche.ToString());
            }

            //Console.WriteLine("prueba reset");
            //goto VolverAPreguntarNCoches;

            VolverAPreguntarNMotos:
            Console.WriteLine("Seleccione el número de Motos");


            if (int.TryParse(Console.ReadLine().Trim(), out NumeroMotos))
            {

            }
            else
            {
                Console.WriteLine("No has introducido un número");
                goto VolverAPreguntarNMotos;
            }

            if (NumeroMotos <= 0) { NumeroMotos = -NumeroMotos; };

            ConfirmarNMotos:
            Console.WriteLine("");
            Console.WriteLine("El numero de motos que tienes es " + NumeroMotos + " ¿Es correcto?");

            Confirmacion = Console.ReadLine().ToLower().Trim();

            switch (Confirmacion)
            {
                case "si":
                case "sí":
                case "s":
                case "yes":
                case "ye":
                case "y":
                    Console.WriteLine("");
                    Console.WriteLine("Perfecto");
                    break;

                case "no":
                case "n":
                    Console.WriteLine("");
                    goto VolverAPreguntarNMotos;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Introduce una confirmación válida (Si o No)");
                    goto ConfirmarNMotos;

            }

            string ModeloMoto;
            float PotenciaMoto;
            string MatriculaMoto;
            int RuedasMoto;
            TipoDeMotor TipoMotorMoto;
            string CambioDeMarchasMoto;
            TipoDeTraccion TipoDeTracciónMoto;
            bool Sidecar;

            SiguienteMoto:
            if (NumeroMotos != 0)
            {
                Console.WriteLine("Cual es el modelo de la moto número " + NumeroMotos);
                ModeloMoto = Console.ReadLine().Trim().ToLower();

                PreguntarPotenciaDeMoto:
                Console.WriteLine("Cual es la potencia (Caballos) de la moto número" + NumeroMotos);
                if (float.TryParse(Console.ReadLine().Trim(), out PotenciaMoto))
                {

                }
                else
                {
                    Console.WriteLine("No has introducido un número");
                    goto PreguntarPotenciaDeMoto;
                }

                Console.WriteLine("Se ha generado una matricula para la moto " + NumeroMotos + " aleatoriamente");
                Random random = new Random();
                char letter1 = (char)random.Next('A', 'Z' + 1);
                char letter2 = (char)random.Next('A', 'Z' + 1);
                char letter3 = (char)random.Next('A', 'Z' + 1);
                int num1 = random.Next(0, 10);
                int num2 = random.Next(0, 10);
                int num3 = random.Next(0, 10);
                int num4 = random.Next(0, 10);
                num1 = num1 * 1000;
                num2 = num2 * 100;
                num3 = num3 * 10;
                MatriculaMoto = num1 + num2 + num3 + num4 + " " + letter1 + letter2 + letter3;
                Console.WriteLine(MatriculaMoto);

                preguntarRuedasMoto:
                Console.WriteLine("Escriba el numero de ruedas de la moto numero " + NumeroMotos + " (2 o 3)");
                int.TryParse(Console.ReadLine().Trim(), out RuedasMoto);
                if (RuedasMoto == 2) { }
                else if (RuedasMoto == 3) { }
                else { Console.WriteLine("No ha introducido un numero correcto"); goto preguntarRuedasMoto; }


                Console.WriteLine("Seleccione el tipo de motor de la moto " + NumeroMotos);
                PreguntarMotorDeMoto:
                Console.WriteLine("Escriba 1 o 2 para elegir Gasolina o Electrico respectivamente");
                int input;
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1)
                {
                    Console.WriteLine("Su moto tiene un motor de " + TipoDeMotor.Gasolina);
                    TipoMotorMoto = TipoDeMotor.Gasolina;
                    goto FinDeMotor;
                }
                else if (input == 2)
                {
                    Console.WriteLine("Su moto tiene un motor " + TipoDeMotor.Electrico);
                    TipoMotorMoto = TipoDeMotor.Electrico;
                    goto FinDeMotor;
                }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarMotorDeMoto;
                }
                FinDeMotor:

                Console.WriteLine("Escriba el típo de cambio de marchas de la moto " + NumeroMotos + " (Automático o Manual)");
                PreguntarMarchasDeMoto:
                CambioDeMarchasMoto = Console.ReadLine().ToLower().Trim();
                switch (CambioDeMarchasMoto)
                {
                    case "automatico":
                    case "automático":
                    case "automatic":
                    case "automátic":
                    case "auto":
                    case "a":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasMoto = "Automático";
                        break;

                    case "manual":
                    case "emanuel":
                    case "emmanuel":
                    case "emannuel":
                    case "emmannuel":
                    case "m":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasMoto = "Manual";
                        break;

                    default:
                        Console.WriteLine("Debe escribir Automático o Manual (Puede escribir 'A' o 'M' en su lugar)");
                        goto PreguntarMarchasDeMoto;
                }

                Console.WriteLine("Seleccione el tipo de tracción del moto " + NumeroMotos);
                PreguntarTraccionDeMoto:
                Console.WriteLine("Escriba 1 2 o 3 para elegir Delantera, Trasera o Total respectivamente");
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1) { Console.WriteLine("Su moto es de tracción " + TipoDeTraccion.Delantera); TipoDeTracciónMoto = TipoDeTraccion.Delantera; }
                else if (input == 2) { Console.WriteLine("Su moto es de tracción " + TipoDeTraccion.Trasera); TipoDeTracciónMoto = TipoDeTraccion.Trasera; }
                else if (input == 3) { Console.WriteLine("Su moto es de tracción " + TipoDeTraccion.Total); TipoDeTracciónMoto = TipoDeTraccion.Total; }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarTraccionDeMoto;
                }
                
                PreguntarSidecar:
                Console.WriteLine("¿Tiene su moto sidecar? Escriba true o false");
                if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out Sidecar)) { }
                else { goto PreguntarSidecar; }

                Moto moto = new Moto(ModeloMoto, PotenciaMoto, MatriculaMoto, RuedasMoto, TipoMotorMoto, CambioDeMarchasMoto, TipoDeTracciónMoto, Sidecar);

                ListaDeMotos.Add(moto);

                NumeroMotos = NumeroMotos - 1;
                goto SiguienteMoto;

            }
            else
            {
                Console.WriteLine("Motos finalizadas");
            }

            foreach (Moto moto in ListaDeMotos)
            {
                Console.WriteLine(moto.ToString());
            }

        //camiones

            VolverAPreguntarNCamiones:
            Console.WriteLine("Seleccione el número de Camiones");


            if (int.TryParse(Console.ReadLine().Trim(), out NumeroCamiones))
            {

            }
            else
            {
                Console.WriteLine("No has introducido un número");
                goto VolverAPreguntarNCamiones;
            }

            if (NumeroCamiones <= 0) { NumeroCamiones = -NumeroCamiones; };

            ConfirmarNCamiones:
            Console.WriteLine("");
            Console.WriteLine("El numero de Camiones que tienes es " + NumeroCamiones + " ¿Es correcto?");

            Confirmacion = Console.ReadLine().ToLower().Trim();

            switch (Confirmacion)
            {
                case "si":
                case "sí":
                case "s":
                case "yes":
                case "ye":
                case "y":
                    Console.WriteLine("");
                    Console.WriteLine("Perfecto");
                    break;

                case "no":
                case "n":
                    Console.WriteLine("");
                    goto VolverAPreguntarNCamiones;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Introduce una confirmación válida (Si o No)");
                    goto ConfirmarNMotos;

            }

            string ModeloCamion;
            float PotenciaCamion;
            string MatriculaCamion;
            int RuedasCamion;
            TipoDeMotor TipoMotorCamion;
            string CambioDeMarchasCamion;
            TipoDeTraccion TipoDeTracciónCamion;
            bool Semirremolque;
            bool semirremolque = false;
            int NumeroRemolques;
            int numeroRemolques = 0;
            string Cabezal;
            bool VehiculoEspecialCamion;

            SiguienteCamion:
            if (NumeroCamiones != 0)
            {
                Console.WriteLine("Cual es el modelo del camión número " + NumeroCamiones);
                ModeloCamion = Console.ReadLine().Trim().ToLower();

                PreguntarPotenciaDeCamion:
                Console.WriteLine("Cual es la potencia (Caballos) del camión número" + NumeroCamiones);
                if (float.TryParse(Console.ReadLine().Trim(), out PotenciaCamion))
                {

                }
                else
                {
                    Console.WriteLine("No has introducido un número");
                    goto PreguntarPotenciaDeCamion;
                }

                Console.WriteLine("Se ha generado una matricula para el camión " + NumeroCamiones + " aleatoriamente");
                Random random = new Random();
                char letter1 = (char)random.Next('A', 'Z' + 1);
                char letter2 = (char)random.Next('A', 'Z' + 1);
                char letter3 = (char)random.Next('A', 'Z' + 1);
                int num1 = random.Next(0, 10);
                int num2 = random.Next(0, 10);
                int num3 = random.Next(0, 10);
                int num4 = random.Next(0, 10);
                num1 = num1 * 1000;
                num2 = num2 * 100;
                num3 = num3 * 10;
                MatriculaCamion = num1 + num2 + num3 + num4 + " " + letter1 + letter2 + letter3;
                Console.WriteLine(MatriculaCamion);

                preguntarRuedasCamion:
                Console.WriteLine("Escriba el numero de ruedas del camión numero " + NumeroCamiones + " (4,6,8,10,12)");
                int.TryParse(Console.ReadLine().Trim(), out RuedasCamion);
                if (RuedasCamion == 4) { }
                else if (RuedasCamion == 6) { }
                else if (RuedasCamion == 8) { }
                else if (RuedasCamion == 10) { }
                else if (RuedasCamion == 12) { }
                else { Console.WriteLine("No ha introducido un numero correcto"); goto preguntarRuedasCamion; }


                Console.WriteLine("Seleccione el tipo de motor del camion " + NumeroCamiones);
                PreguntarMotorDeCamion:
                Console.WriteLine("Escriba 1 o 2 para elegir Gasolina o Diesel respectivamente");
                int input;
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1)
                {
                    Console.WriteLine("Su camión tiene un motor de " + TipoDeMotor.Gasolina);
                    TipoMotorCamion = TipoDeMotor.Gasolina;
                    goto FinDeMotor;
                }
                else if (input == 2)
                {
                    Console.WriteLine("SSu camión tiene un motor " + TipoDeMotor.Diesel);
                    TipoMotorCamion = TipoDeMotor.Diesel;
                    goto FinDeMotor;
                }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarMotorDeCamion;
                }
                FinDeMotor:

                Console.WriteLine("Escriba el típo de cambio de marchas del camión " + NumeroCamiones + " (Automático o Manual)");
                PreguntarMarchasDeCamion:
                CambioDeMarchasCamion = Console.ReadLine().ToLower().Trim();
                switch (CambioDeMarchasCamion)
                {
                    case "automatico":
                    case "automático":
                    case "automatic":
                    case "automátic":
                    case "auto":
                    case "a":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasCamion = "Automático";
                        break;

                    case "manual":
                    case "emanuel":
                    case "emmanuel":
                    case "emannuel":
                    case "emmannuel":
                    case "m":
                        Console.WriteLine("Confirmado");
                        CambioDeMarchasCamion = "Manual";
                        break;

                    default:
                        Console.WriteLine("Debe escribir Automático o Manual (Puede escribir 'A' o 'M' en su lugar)");
                        goto PreguntarMarchasDeCamion;
                }

                Console.WriteLine("Seleccione el tipo de tracción del camión " + NumeroCamiones);
                PreguntarTraccionDeCamion:
                Console.WriteLine("Escriba 1 2 o 3 para elegir Delantera, Trasera o Total respectivamente");
                int.TryParse(Console.ReadLine().Trim(), out input);
                if (input == 1) { Console.WriteLine("Su camión es de tracción " + TipoDeTraccion.Delantera); TipoDeTracciónCamion = TipoDeTraccion.Delantera; }
                else if (input == 2) { Console.WriteLine("Su camión es de tracción " + TipoDeTraccion.Trasera); TipoDeTracciónCamion = TipoDeTraccion.Trasera; }
                else if (input == 3) { Console.WriteLine("Su camión es de tracción " + TipoDeTraccion.Total); TipoDeTracciónCamion = TipoDeTraccion.Total; }
                else
                {
                    Console.WriteLine("Error");
                    goto PreguntarTraccionDeCamion;
                }

                Console.WriteLine("Escriba el típo de cabezal del camión " + NumeroCamiones + " (Plano u Aerodinámico)");
                PreguntarCabezalDeCamion:
                Cabezal = Console.ReadLine().ToLower().Trim();
                switch (Cabezal)
                {
                    case "plano":
                    case "plane":
                    case "plan":
                    case "pl":
                    case "planeta":
                    case "p":
                        Console.WriteLine("Confirmado");
                        Cabezal = "Plano";
                        break;

                    case "aerodinámico":
                    case "aerodinamico":
                    case "aero":
                    case "dinamico":
                    case "ad":
                    case "a":
                        Console.WriteLine("Confirmado");
                        Cabezal = "Aerodinámico";
                        break;

                    default:
                        Console.WriteLine("Debe escribir Automático o Manual (Puede escribir 'P' o 'A' en su lugar)");
                        goto PreguntarCabezalDeCamion;
                }

                if (RuedasCamion == 4) 
                {
                    Console.WriteLine("Ya que su camión tiene 4 ruedas este solo puede llevar un semirremolque");
                    PreguntarSemirremolque:
                    Console.WriteLine("¿Lo lleva? (Escriba: True o False)");
                    if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out semirremolque)) { }
                    else { goto PreguntarSemirremolque; }
                }
                else if (RuedasCamion == 6) 
                {
                    Console.WriteLine("Ya que su camión tiene 6 ruedas este solo puede llevar un Remolque");
                    PreguntarSemirremolque:
                    Console.WriteLine("¿Cuantos tiene? (Escriba: 0 o 1)");
                    if (int.TryParse(Console.ReadLine().Trim().ToLower(), out numeroRemolques)) 
                    {
                        if (numeroRemolques == 0) { }
                        else if (numeroRemolques == 1) { }
                        else { goto PreguntarSemirremolque; }
                    }
                    else { goto PreguntarSemirremolque; }
                }
                else if (RuedasCamion == 8) 
                {
                    Console.WriteLine("Ya que su camión tiene 8 ruedas este un remolque y un semirremolque");
                    PreguntarSemirremolque:
                    Console.WriteLine("¿Lleva semirremolque? (Escriba: True o False)");
                    if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out semirremolque)) { }
                    else { goto PreguntarSemirremolque; }
                    PreguntarRemolque:
                    Console.WriteLine("¿Cuantos remolques tiene? (Escriba: 0 o 1)");
                    ;
                    if (int.TryParse(Console.ReadLine().Trim().ToLower(), out numeroRemolques)) 
                    {
                        if (numeroRemolques == 0) { }
                        else if (numeroRemolques == 1) { }
                        else { goto PreguntarSemirremolque; }
                    }
                    else { goto PreguntarRemolque; }
                }
                else if (RuedasCamion == 10) 
                {
                    Console.WriteLine("Ya que su camión tiene 10 ruedas este puede llevar uno o dos Remolques");
                    PreguntarSemirremolque:
                    Console.WriteLine("¿Cuantos tiene? (Escriba: 0, 1 o 2)");
                    if (int.TryParse(Console.ReadLine().Trim().ToLower(), out numeroRemolques))
                    {
                        if (numeroRemolques == 0) { }
                        else if (numeroRemolques == 1) { }
                        else if (numeroRemolques == 2) { }
                        else { goto PreguntarSemirremolque; }
                    }
                    else { goto PreguntarSemirremolque; }
                }
                else if (RuedasCamion == 12) 
                {
                    Console.WriteLine("Ya que su camión tiene 12 ruedas este puede llevar uno, dos o tres Remolques");
                    PreguntarSemirremolque:
                    Console.WriteLine("¿Cuantos tiene? (Escriba: 0, 1, 2 o 3)");
                    if (int.TryParse(Console.ReadLine().Trim(), out numeroRemolques))
                    {
                        if (numeroRemolques == 0) { numeroRemolques = 0; }
                        else if (numeroRemolques == 1) { }
                        else if (numeroRemolques == 2) { }
                        else if (numeroRemolques == 3) { }
                        else { goto PreguntarSemirremolque; }
                    }
                }

                Semirremolque = semirremolque;
                NumeroRemolques = numeroRemolques;

            PreguntarVehiculoEspecialCamion:
                Console.WriteLine("¿Es su camión un vehiculo especial? Escriba true o false");
                if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out VehiculoEspecialCamion)) { }
                else { goto PreguntarVehiculoEspecialCamion; }

                Camion camion = new Camion(ModeloCamion, PotenciaCamion, MatriculaCamion, RuedasCamion, TipoMotorCamion, CambioDeMarchasCamion, TipoDeTracciónCamion, Semirremolque ,NumeroRemolques, Cabezal, VehiculoEspecialCamion);

                ListaDeCamiones.Add(camion);

                NumeroCamiones = NumeroCamiones - 1;
                goto SiguienteCamion;

            }
            else
            {
                Console.WriteLine("Camiones finalizados");
            }

            foreach (Camion camion in ListaDeCamiones)
            {
                Console.WriteLine(camion.ToString());
            }

            int selectorFinal;
            bool seguro;
            bool seguroCoches;
            bool seguroMotos;
            bool seguroCamiones;

            Console.WriteLine("");
            Console.WriteLine("Ha finalizado la creación de los Vehiculos");
            escribaNumeros:

            Console.WriteLine("");
            Console.WriteLine("Escriba 1 para ver todos os vehiculos juntos");
            Console.WriteLine("Escriba 2 para editar los Vehiculos");
            Console.WriteLine("Escriba 3 para cerrar");

            if (int.TryParse(Console.ReadLine().Trim().ToLower(), out selectorFinal)) 
            { 
                if (selectorFinal == 1) 
                {
                    foreach (Coche coche in ListaDeCoches)
                    {
                        Console.WriteLine(coche.ToString());
                    }

                    foreach (Moto moto in ListaDeMotos)
                    {
                        Console.WriteLine(moto.ToString());
                    }

                    foreach (Camion camion in ListaDeCamiones)
                    {
                        Console.WriteLine(camion.ToString());
                    }
                    goto escribaNumeros;
                }
                else if (selectorFinal == 2) 
                { 
                    Console.WriteLine("A la hora de editar los Vehiculos deberás rehacer todos los de esa categoria");
                    Console.WriteLine("Si quieres editar los coches todos los anteriores se vaciarán pero no tendrás que rehacer las motos o camiones");
                    Console.WriteLine("Si decides editar deberás introducir de nuevo el numero de vehiculos, introduce 0 a los que no quieras añadir nada o introduce un número nuevo para el numero de vehiculos que quieras añadir sobre los que ya tenías");
                    Console.WriteLine("¿Está seguro de querer editar los vehiculos? (Escriba: True o False para si o no respectivamente)");
                    escribisteMal:
                    if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out seguro)) 
                    {
                        if (seguro == true) 
                        { 
                            Console.WriteLine("¿Desea Borrar los coches? (Escriba: True o False para si o no respectivamente)");
                            escribisteMalLosCoches:
                            if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out seguroCoches)) { if (seguroCoches == true) { ListaDeCoches.Clear(); } else { } }
                            else { Console.WriteLine("Escriba: True o False para si o no respectivamente"); goto escribisteMalLosCoches;  }

                            Console.WriteLine("¿Desea Borrar las Motos? (Escriba: True o False para si o no respectivamente)");
                            escribisteMalLasMotos:
                            if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out seguroMotos)) { if (seguroMotos == true) { ListaDeMotos.Clear(); } else { } }
                            else { Console.WriteLine("Escriba: True o False para si o no respectivamente"); goto escribisteMalLasMotos; }

                            Console.WriteLine("¿Desea Borrar las Motos? (Escriba: True o False para si o no respectivamente)");
                            escribisteMalLosCamiones:
                            if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out seguroCamiones)) { if (seguroCamiones == true) { ListaDeCamiones.Clear(); } else { } }
                            else { Console.WriteLine("Escriba: True o False para si o no respectivamente"); goto escribisteMalLosCamiones; }

                            goto VolverAPreguntarNCoches;

                        }
                        if (seguro == false) { goto escribaNumeros; }
                    }
                    else 
                    {
                        Console.WriteLine("Escriba: True o False para si o no respectivamente");
                        goto escribisteMal; 
                    }
                }
                else if (selectorFinal == 3) 
                { 
                    Console.WriteLine("¿Seguro que desea cerrar? (Escriba: True o False para si o no respectivamente)");
                    escribisteMal:
                    if (bool.TryParse(Console.ReadLine().Trim().ToLower(), out seguro))
                    {
                        if (seguro == true) { }
                        if (seguro == false) { goto escribaNumeros; }
                    }
                    else
                    {
                        Console.WriteLine("Escriba: True o False para si o no respectivamente");
                        goto escribisteMal;
                    }
                }
                else { goto escribaNumeros; }
            }
            else { goto escribaNumeros; }



        }




        abstract class Vehiculo
        {
            public string Modelo { get; set; }
            public float Potencia { get; set; }
            public string Matricula { get; set; }
            public int Ruedas { get; set; }
            public TipoDeMotor TipoMotor { get; set; }
            public string CambioDeMarchas { get; set; }
            public TipoDeTraccion TipoTraccion { get; set; }

            public Vehiculo(string modelo, float potencia, string matricula, int ruedas, TipoDeMotor tipoMotor, string cambioDeMarchas, TipoDeTraccion tipoTraccion)
            {
                Modelo = modelo;
                Potencia = potencia;
                Matricula = matricula;
                Ruedas = ruedas;
                TipoMotor = tipoMotor;
                CambioDeMarchas = cambioDeMarchas;
                TipoTraccion = tipoTraccion;
            }
            public override string ToString()
            {
                Console.WriteLine("");
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Potencia: " + Potencia);
                Console.WriteLine("Matricula: " + Matricula);
                Console.WriteLine("Ruedas: " + Ruedas);
                Console.WriteLine("Tipo de motor: " + TipoMotor);
                Console.WriteLine("Cambio de marchas: " + CambioDeMarchas);
                Console.WriteLine("Tipo de tracción: " + TipoTraccion);
                return $"";
            }
        }

        class Coche : Vehiculo
        {
            public int NumeroPuertas { get; set; }
            public bool VehiculoEspecial { get; set; }
            public bool ServicioPublico { get; set; }
            public bool TintarVentanillasTraseras { get; set; }

            public Coche(string modelo, float potencia, string matricula, int ruedas, TipoDeMotor tipoMotor, string cambioDeMarchas, TipoDeTraccion tipoTraccion, int numeroPuertas, bool vehiculoEspecial, bool servicioPublico, bool tintarVentanillasTraseras) :
                base(modelo, potencia, matricula, ruedas, tipoMotor, cambioDeMarchas, tipoTraccion)
            {
                NumeroPuertas = numeroPuertas;
                VehiculoEspecial = vehiculoEspecial;
                ServicioPublico = servicioPublico;
                TintarVentanillasTraseras = tintarVentanillasTraseras;
            }
            public override string ToString()
            {
                Console.WriteLine("-Coche-");
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Potencia: " + Potencia);
                Console.WriteLine("Matrícula: " + Matricula);
                Console.WriteLine("Número de ruedas: " + Ruedas);
                Console.WriteLine("Tipo de motor: " + TipoMotor);
                Console.WriteLine("Cambio de marchas: " + CambioDeMarchas);
                Console.WriteLine("Tipo de tracción: " + TipoTraccion);

                Console.WriteLine("Numero de puertas: " + NumeroPuertas);
                if (VehiculoEspecial = true) { Console.WriteLine("Es un coche especial"); }
                else { Console.WriteLine("No es un coche especial"); }
                if (ServicioPublico = true) { Console.WriteLine("Es un coche de sevicio publico"); }
                else { Console.WriteLine("Es un coche de sevicio publico"); }
                if (TintarVentanillasTraseras= true) { Console.WriteLine("Tiene las ventanillas tintadas"); }
                else { Console.WriteLine("No tiene las ventanillas tintadas"); }
                return $"";
            }
        }

        class Moto : Vehiculo
        {
            public bool Sidecar { get; set; }

            public Moto(string modelo, float potencia, string matricula, int ruedas, TipoDeMotor tipoMotor, string cambioDeMarchas, TipoDeTraccion tipoTraccion, bool sidecar) :
                base(modelo, potencia, matricula, ruedas, tipoMotor, cambioDeMarchas, tipoTraccion)
            {
                Sidecar = sidecar;
            }
            public override string ToString()
            {
                Console.WriteLine("-Moto-");
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Potencia: " + Potencia);
                Console.WriteLine("Matricula: " + Matricula);
                Console.WriteLine("Número de ruedas: " + Ruedas);
                Console.WriteLine("Tipo de motor: " + TipoMotor);
                Console.WriteLine("Cambio de marchas: " + CambioDeMarchas);
                Console.WriteLine("Tipo de tracción: " + TipoTraccion);

                if (Sidecar == true) { Console.WriteLine("La moto tiene sidecar"); }
                else { Console.WriteLine("La moto no tiene sidecar"); }
                return $"";
            }
        }

        class Camion : Vehiculo
        {
            public bool Semirremolque { get; set; }
            public int NumeroRemolques { get; set; }
            public string Cabezal { get; set; }
            public bool VehiculoEspecial { get; set; }

            public Camion(string modelo, float potencia, string matricula, int ruedas, TipoDeMotor tipoMotor, string cambioDeMarchas, TipoDeTraccion tipoTraccion, bool semirremolque, int numeroRemolques, string cabezal, bool vehiculoEspecial) :
                base(modelo, potencia, matricula, ruedas, tipoMotor, cambioDeMarchas, tipoTraccion)

            {
                Semirremolque = semirremolque;
                NumeroRemolques = numeroRemolques;
                Cabezal = cabezal;
                VehiculoEspecial = vehiculoEspecial;
            }
            public override string ToString()
            {
                Console.WriteLine("-Camión-");
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Potencia: " + Potencia);
                Console.WriteLine("Matricula: " + Matricula);
                Console.WriteLine("Número de ruedas: " + Ruedas);
                Console.WriteLine("Tipo de motor: " + TipoMotor);
                Console.WriteLine("Cambio de marchas: " + CambioDeMarchas);
                Console.WriteLine("Tipo de tracción: " + TipoTraccion);

                Console.WriteLine("Tiene " + NumeroRemolques + " remolques");
                Console.WriteLine("Tiene una cabeza " + Cabezal);
                if (VehiculoEspecial == true) { Console.WriteLine("Es un camión especial"); }
                else { Console.WriteLine("No es un camión especial"); }
                return $"";
            }

        }

    }
}