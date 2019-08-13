using System;

namespace Frø_hop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            int X = 10;
            //Mål
            int Y = 8676461;
            //Længde
            int D = 3;
            int hop;

            //Hopper indtil mål
            for (hop = 1 ; X <= (Y - 1); hop++)
            {
                X = X + D;
                Console.WriteLine("Efter " + hop + ". hop landede du på: " + X);
            }
            hop--;
            Console.WriteLine("");
            Console.WriteLine("Du landede på " + X + "!");
            Console.WriteLine("Det tog " + hop + " hop før du landede på eller efter " + Y);
        }
    }
}
