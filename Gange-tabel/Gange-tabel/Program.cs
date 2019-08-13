using System;

namespace Gange_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vertical
            for (int v = 1; v <= 10; v++)
            {
                //Horisontal
                for (int h = 1; h <= 10; h++)
                {
                    int t = v * h;
                    Console.Write(t.ToString().PadLeft(3, ' ') + " ");
                }
             Console.WriteLine(" ");
            }
        }
    }
}

/* 
Du må KUN anvende for loops, variable, udregning,
PadLeft metoden og output med Console.WriteLine()
*/