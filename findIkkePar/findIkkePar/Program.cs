using System;
using System.Collections.Generic;

namespace findIkkePar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("findIkkePar");

            int[] Array = { 1, 4, 6, 1, 6, 9, 4 };
            int checkMatch;
            List<int> allMatch = new List<int>();


            for (int n = 1; n < Array.Length; n++)
            {
                for (int i = 1; i < Array.Length; i++)
                {
                    checkMatch = Array[n] - Array[i];
                    if (checkMatch != 0)
                    {
                        Console.WriteLine(Array[n] + " og " + Array[i] + " danner IKKE par.");
                    }
                    else
                    {
                        Console.WriteLine(Array[n] + " og " + Array[i] + " danner par.");
                        allMatch.Add(Array[n]);

                    }
                }
            }
            var allMatchArray = allMatch.ToArray();
            
            Console.WriteLine("Debug");
            for (int i = 0; i < allMatchArray.Length; i++)
            {
                Console.WriteLine(allMatchArray[i]);
                
            }
            Console.WriteLine("Debug");



                    }
                }

            }
        }
    }
}
