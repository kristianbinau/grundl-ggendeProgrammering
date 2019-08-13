using System;
using System.Collections.Generic;
using System.Text;

namespace regneSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string disciplin;
            int difficulty;
            string minusOrPlus;

            //Rules and Info
            Console.WriteLine("RegneSpil!");
            Console.WriteLine("Du starter med (100 * Det niveau du vælger) af points. Hvor du så få eller mister nogle hvis du svare rigtigt og forkert.");
            Console.WriteLine("Du får 10 regnestykker, hvor du så får en score efter.");
            Console.WriteLine("Held og lykke!");
            Console.WriteLine(" ");


            //Infinite Loop
            for (int i = 0; i < 9999; i--)
            {
                //User-input
                Console.WriteLine("Hvilken disciplin vil du op i?");
                disciplin = Console.ReadLine();
                Console.WriteLine("Vil du regne med '+' eller '-' tal?");
                minusOrPlus = Console.ReadLine();
                Console.WriteLine("Hvilken sværhedsgrad vil du prøve? (1-5)");
                difficulty = int.Parse(Console.ReadLine());

                
                
                //Turning user-input into functions
                switch (disciplin)
                {
                    case "+":
                    case "plus":
                    case "Plus":
                        disciplinFunction(difficulty, minusOrPlus, "+");
                        break;

                    case "-":
                    case "minus":
                    case "Minus":
                        disciplinFunction(difficulty, minusOrPlus, "-");
                        break;

                    case "*":
                    case "gange":
                    case "Gange":
                        disciplinFunction(difficulty, minusOrPlus, "*");
                        break;

                    case "/":
                    case "dividere":
                    case "Dividere":
                        disciplinFunction(difficulty, minusOrPlus, "/");
                        break;

                    default:
                        Console.WriteLine("Du intastede ikke en rigtig operator!");
                        break;
                }
                Console.WriteLine(" ");
                
            }
        }

        static void disciplinFunction(int d, string e, string f)
        {
            int points = d * 100;
            string disciplin = f;
            
            //Gives 10 math-problems
            for (int j = 0; j < 10; j++)
            {
            //Getting Random numbers from Function
            int num1 = difficultyRandomNumber(d, e);
            int num2 = difficultyRandomNumber(d, e);

                int trueResult;

                //Vælger disciplin
                switch (disciplin)
                    {
                    case "+":
                        trueResult = num1 + num2;

                        Console.WriteLine(" ");
                        Console.WriteLine("Hvad er " + num1 + " " + disciplin + " " + num2 + "?");
                        break;
                    case "-":
                        trueResult = num1 - num2;

                        Console.WriteLine(" ");
                        Console.WriteLine("Hvad er " + num1 + " " + disciplin + " " + num2 + "?");
                        break;
                    case "*":
                        trueResult = num1 * num2;

                        Console.WriteLine(" ");
                        Console.WriteLine("Hvad er " + num1 + " " + disciplin + " " + num2 + "?");
                        break;
                    case "/":
                        trueResult = num1 / num2;

                        Console.WriteLine(" ");
                        Console.WriteLine("Hvad er " + num1 + " " + disciplin + " " + num2 + "?");
                        break;
                    default:
                        trueResult = 0;
                        break;
                }

                int ansResult;

                //Counting Tries
                for (int i = 1; i <= 3; i++)
                {
                    //User-input
                    ansResult = int.Parse(Console.ReadLine());

                    if (ansResult == trueResult)
                    {
                        //Rigtig
                        Console.WriteLine("Hurra! Du regnede rigtigt, du brugte " + (i) + " forsøg!");
                        points = points + 10;
                        Console.WriteLine("Du fik 10 points!");

                        break;
                    }
                    else
                    {
                        //Forkert
                        if (i <= 2)
                        {
                            Console.WriteLine("Øv... Du regnede ikke rigtigt, det er vel okay for du har " + (3 - i) + " forsøg tilbage!");
                            points = points - (5 * i);
                            Console.WriteLine("Du mistede " + 5 * i + " points...");
                        }
                        else
                        {
                            Console.WriteLine("Du fik heller ikke rigtigt denne gang, det var trist. Svaret var " + trueResult);
                            points = points - 15;
                            Console.WriteLine("Du mistede 15 points...");
                        }
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Score:");
            Console.WriteLine("Sværhedsgrad = " + d);
            Console.WriteLine("Points = " + points);
            Console.WriteLine(" ");
            if (points >= (d * 100) + 75)
            {
                Console.WriteLine("Du var virkelig dygtig, du burde gå et niveau op!");
            }
            else if (points <= (d * 100) - 25 && d > 1)
            {
                Console.WriteLine("Måske var det her niveau lidt for højt, du burde gå et niveau ned...");
            }
            else
            {
                Console.WriteLine("Du gjorde det udemærket, du skal bare øve dig lidt mere, så kan du gå et niveau op!");
            }
            Console.WriteLine(" ");
        }
        //Random-number generator
        static int difficultyRandomNumber(int diff, string overAndUnder)
        {
            int plusOrMinus;
            int difficultyMax;
            int difficultyMin;

            //Checker om man vil have plus eller minus tal
            switch (overAndUnder)
            {
                case "+":
                case "plus":
                case "Plus":
                    plusOrMinus = 0;
                    break;

                case "-":
                case "minus":
                case "Minus":
                    plusOrMinus = 5;
                    break;
                
                default:
                    Console.WriteLine("Du intastede ikke et rigtigt '+' eller '-'!");
                    plusOrMinus = 0;
                    break;

            }

            int difficulty = diff + plusOrMinus;

            //Sætter grænsen for hvor højt tallet må være afhængigt af sværhedsgrad og om man vil have plus eller minus.
            switch (difficulty)
            {
                case 1:
                    difficultyMax = 11;
                    difficultyMin = 0;
                    break;
                case 2:
                    difficultyMax = 101;
                    difficultyMin = 11;
                    break;
                case 3:
                    difficultyMax = 1001;
                    difficultyMin = 101;
                    break;
                case 4:
                    difficultyMax = 10001;
                    difficultyMin = 1001;
                    break;
                case 5:
                    difficultyMax = 100000001;
                    difficultyMin = 10001;
                    break;
                case 6:
                    difficultyMin = -11;
                    difficultyMax = 0;
                    break;
                case 7:
                    difficultyMin = -101;
                    difficultyMax = -11;
                    break;
                case 8:
                    difficultyMin = -1001;
                    difficultyMax = -101;
                    break;
                case 9:
                    difficultyMin = -10001;
                    difficultyMax = -1001;
                    break;
                case 10:
                    difficultyMin = -100000001;
                    difficultyMax = -10001;
                    break;

                default:
                    Console.WriteLine("Du intastede ikke en sværhedsgrad mellem 1-5!");
                    difficultyMax = 69;
                    difficultyMin = 69;
                    break;
            }

            Random rand = new Random();
            int randNum = rand.Next(difficultyMin, difficultyMax);

            return randNum;
        }
    }
}
