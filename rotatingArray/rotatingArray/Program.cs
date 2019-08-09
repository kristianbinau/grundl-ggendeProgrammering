using System;

namespace rotatingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int rotate = 2;

            Console.WriteLine("Array Before:");

            for (var i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write(Array.GetValue(i));
            }
            
            for (int n = 1; n <= rotate; n++)
            {
                var last = Array[Array.Length - 1];

                for(var i = Array.Length - 2; i >= 0; i--)
                {
                    Array[i + 1] = Array[i];

                }
                Array[0] = last;
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Array After:");
            for (var i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write(Array.GetValue(i));
            }
        }
    }
}
