using System;

namespace lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num0;
            int num1;
            string stringOperation;
            int operation = ' ';
            int output =' ';
            int done = 1;

            //Uendelig loop
            while (done == 1)
            {
                //User-input
                Console.WriteLine("LOMMEREGNER");
                Console.WriteLine("Instast det første tal: ");
                num0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Instast det andet tal: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Instast operatoren: ");
                stringOperation = Console.ReadLine();

                //Gør det muligt både og skrive "+" eller "addition"
                if (stringOperation == "+" || stringOperation == "addition")
                {
                    operation = 1;
                }
                else if (stringOperation == "-" || stringOperation == "soustraction")
                {
                    operation = 2;
                }
                else if (stringOperation == "*" || stringOperation == "multiplication")
                {
                    operation = 3;
                }
                else if (stringOperation == "/" || stringOperation == "division")
                {
                    operation = 4;
                }
                else if (stringOperation == "%" || stringOperation == "reste")
                {
                    operation = 5;
                }

                //Laver regnestykket afhængigt af user-input
                switch (operation)
                {
                    case 1:
                        output = num0 + num1;
                        break;

                    case 2:
                        output = num0 - num1;
                        break;

                    case 3:
                        output = num0 * num1;
                        break;

                    case 4:
                        output = num0 / num1;
                        break;

                    case 5:
                        output = num0 % num1;
                        break;
                }
                Console.WriteLine("\nResult of " + num0 + " " + stringOperation + " " + num1 + " = " + output + ".");
                Console.WriteLine(" ");
                Console.WriteLine("Press ENTER");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
        }
    }
}
