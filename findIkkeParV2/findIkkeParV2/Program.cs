using System;
using System.Collections.Generic;

namespace findIkkeParV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int check = CheckIfOdd(num.Next(1, 1000000));
            int counter = 1;

            while (check <= 0)
            {
                if (check % 2 == 0)
                {
                    check = CheckIfOdd(num.Next(1, 1000000)); ;
                }
                counter++;
            }
            int[] nArray = new int[check];
            int arLength = 0;
            //generate arrays with pairs of numbers, and one number which does not pair.
            for (int i = 0; i < check; i++)
            {
                arLength = nArray.Length;

                if (arLength == i + 1)
                {
                    nArray[i] = i + 1;
                }
                else
                {
                    nArray[i] = i;
                    nArray[i + 1] = i;
                }
                i++;
            }


            var noPairs = nArray.GroupBy(i => i)
                    .Where(g => g.Count() % 2 == 1)
                    .Select(g => g.Key);

            for (int i = 0; i <= arLength; i++)
            { // go through the array one by one..
                var number = nArray[i];

                // now search through the array for a match.
                for (int e = 0; e <= arLength; e++)
                {
                    if (e != i)
                    {

                    }
                }
            }
        }
    }
}
