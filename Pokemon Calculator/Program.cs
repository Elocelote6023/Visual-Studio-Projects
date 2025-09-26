// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //No pregunta nada por consola. Modificar datos a mano y quitar comentario a lo que se quiera escribir

    static void Main()
    {
        double burn = 1; // 1 - 0.5
        double targets = 1; // 1 pega a un pokemon - 0.75 pega a 2 en dobles - 0.5 pega a todos (royale/incursiones)
        double Weather = 1; // 1 - 1.5
        double Campo = 1;

        double attack = 317;
        double defense = 169;
        double superefectivo = 1; // 0.125, 0.25, 0.5 (not very effective); 1 (normal); 2, 4, or 8 (super effective)
        double Nivel = 100;
        double Power = 140;
        double crit = 1; // 1 - 2
        double STAB = 1.5; // 1 - 1.5 - 2

        double other = 1; // items habilidades etc

        Random random = new Random();
        double numeroAleatoriocore = random.Next(85, 101);
        double numeroBleatorio = numeroAleatoriocore / 100;

        // aqui el if para los bonos de ataque/defensa

        double numerodouble = ((((((2 * Nivel) / 5) + 2) * Power * (attack / defense)) / 50) + 2) * targets * Weather * Campo * crit * STAB * superefectivo * burn * other * numeroBleatorio;

        int numeroint = (int)numerodouble;

        // ------ CALCULAR ATAQUE ------
        //Console.WriteLine(numeroint);
        Console.WriteLine("");

        // 3 - 2.6666 - 2.3333 - 2 - 1.6666 - 1.3333 - 1 - 0.75 - 0.6 - 0.5 - 0.4285 - 0.375 - 0.3333
        double nivelPrecision = 1; // min precision 0.3333
        double nivelEvasion = 1.6666; // max evasion 3
        
        double precisionMovimiento = 100;

        // ------ CALCULAR PRECISÓN ------
        //Console.WriteLine(precisionMovimiento * (nivelPrecision / nivelEvasion));


        double maxHP = 58;
        double currentHP = 1;
        double pokemonCR = 90;
        double ballCR = 2; 
        double status = 1.5; // nada 1 - par poi brn 1.5 - sle frz 2

        double finalCR = (((3 * maxHP - 2 * currentHP) * (pokemonCR * ballCR)) / (3 * maxHP)) * status;

        // ------ CALCULAR POKEBALL ------
        //Console.WriteLine(finalCR/2.55);

        double baseExp = 175;
        double levelDefeated = 30;
        double levelOwnPk = 34;
        double noestupkm = 1; // 1 si es - 1.5 si no
        double canceladoEvo = 1; // 1 si no - 1.2 si el pkm podia evolucionar pero no lo hizo (cuando evolucione vuelve a 1)

        double primeraParte = (baseExp * levelDefeated) / 5;
        double segundaParte = (2 * levelDefeated + 10) / (levelDefeated + levelOwnPk + 10);
        double elevarParte2 = (double)Math.Pow(segundaParte, 2.5);

        double modificadoresExp = noestupkm * canceladoEvo;

        double expTotal = (primeraParte * elevarParte2 + 1) * modificadoresExp;

        // ------ CALCULAR EXPERIENCIA ------
        //Console.WriteLine(expTotal);

    }
}