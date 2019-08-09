using System;

namespace terningerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numDice;
            int trow;
            var trowCount = 0;

            Console.Write("Hvor mange terninger vil du bruge: ");
            numDice = int.Parse(Console.ReadLine());

            int[] trowAll = new int[numDice];

            do
            {
                for(int i = 1; i <= numDice; i++)
                {
                    trowAll[i] = dice.Next(1, 7);
                    Console.WriteLine(trowAll[i] +  " nr. = " + i);
                }

                trowCount++;
                Console.WriteLine("Kast: " + trowCount);
            } while (trowAll[1] == 6 * numDice);

            Console.WriteLine("Der blev brugt " + trowCount + " kast, for at alle " + numDice + " terninger landede på 6");
        }
    }
}
