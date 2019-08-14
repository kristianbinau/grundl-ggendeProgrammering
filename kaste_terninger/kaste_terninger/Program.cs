using System;

namespace kaste_Terninger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random dice = new Random();
            int numDice;
            int trow;
            var trowCount = 0;
            var trowAll = 0;
            
            //USer-input
            Console.Write("Hvor mange terninger vil du bruge: ");
            numDice = int.Parse(Console.ReadLine());

            //Smider 1 terning med 6 * antal terninger sider, og stopper først når der bliver slået det højeste tal.
            do
            {
                trow = dice.Next(1, Convert.ToInt32(Math.Pow(6,numDice)));
                trowCount++;
                Console.WriteLine("Kast: " + trowCount);
            } while (trow != 6 * numDice);

            Console.WriteLine("Der blev brugt " + trowCount + " kast, for at alle " + numDice + " terninger landede på 6");
        }
    }
}
/*
Lav et konsol-program, hvor det handler om at slå 6’ere med et
valgfrit antal terninger.
Når programmet starter skal man indtaste et antal terninger.
Programmet skal så ”kaste” terningerne og tælle hvor mange kast,
der skal til at slå ”rene” seksere
(alle terninger viser 6 i samme kast).
*/