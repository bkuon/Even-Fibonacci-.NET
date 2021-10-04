using System;

namespace Even_Fibonacci
{
    class Program
    {
        static long evenFib(int n)
        {
            if(n < 1)
            {
                return n;
            }
            if(n == 1){
                return 2;
            }

            return ((4* evenFib(n-1)) + evenFib(n - 2));
        }
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine(evenFib(n));
        }
    }
}
