using System;

namespace tema_recursivitate3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the index of the sequence: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Fibonacci of {i} = " + GetFibonacciSequence(i));
            }
        }

        public static int GetFibonacciSequence(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            return (GetFibonacciSequence(n - 1) + GetFibonacciSequence(n - 2));
        }
    }
}
