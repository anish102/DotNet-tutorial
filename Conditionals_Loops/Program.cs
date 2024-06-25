using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = new int[] { 1, 2, 5, 7, 8, 9, 43, 76 };
            Console.WriteLine("Even numbers are:");
            foreach (int i in lst)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}