using System;

namespace IntSwap
{
    class SwapInt
    {
        public static string Swap(int A, int B)
        {
            B = A + B;
            A = B - A;
            B = B - A;

            return $"{A}, {B}";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("IntegerSwap.Main()");
        }
    }
}
