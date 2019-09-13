using System;
using System.Collections.Generic;

namespace testingGrounds
{
    public class Numbers
    {
        private int _sample;
        public int Sample
        {
            // Return the value stored in a field.
            get { return _sample; }
            // Store the value in the field.
            set { _sample = value; }
        }

        private int num1;
        private int num2;
        public void getAddition()
        {
            Console.WriteLine(num1 + num2);
        }
        public void setAddition(int a, int b)
        {
            num1 = a;
            num2 = b;

            Console.WriteLine("The Values has changed");
        }
    }

    public class Display
    {
        static void Main(string[] args)
        {
            Numbers obj = new Numbers();
            obj.setAddition(2, 3);
            obj.getAddition();
            Console.ReadKey();

            //List tests
            List<int> myInts = new List<int>();
            myInts.Add(5);
            myInts.Add(10);
            myInts.Add(11);

            Console.WriteLine(myInts[1]);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Player 1");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Player 2");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\tRound: 1");
            Console.WriteLine(" A B C D     + - - - +     E F G H\tTurn: Player 1");
            Console.WriteLine(" + - - +     |       |     + - - +\tDice: 6");
            Console.WriteLine(" |     |     |       |     |     |");
            Console.WriteLine(" |     |     |       |     |     |");
            Console.WriteLine(" + - - +     |       |     + - - +");
            Console.WriteLine("             |       |");
            Console.WriteLine(" + - - - - - +   #   + - - - - - +");
            Console.WriteLine(" |               #               |");
            Console.WriteLine(" |           # # # # #           |");
            Console.WriteLine(" |               #               |");
            Console.WriteLine(" + - - - - - +   #   + - - - - - +");
            Console.WriteLine("             |       |");
            Console.WriteLine(" + - - +     |       |     + - - +");
            Console.WriteLine(" |     |     |       |     |     |");
            Console.WriteLine(" |     |     |       |     |     |");
            Console.WriteLine(" + - - +     |       |     + - - +");
            Console.WriteLine(" M N O P     + - - - +     I J K L");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player 4");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Player 3");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
