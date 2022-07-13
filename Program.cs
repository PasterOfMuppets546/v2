using System;

namespace look_and_listened
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 11)
            {
            for(int x = 0; x<i; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("Hello, World");
                i++;

            }
        }
    }
}
