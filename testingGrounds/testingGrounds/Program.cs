using System;
using System.Collections.Generic;

namespace testingGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>();
            myInts.Add(5);
            myInts.Add(10);
            myInts.Add(11);

            Console.WriteLine(myInts[1]);
        }
    }
}
