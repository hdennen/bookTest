using System;

namespace BookStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Liquidity.GetBookSnapshot().GetAwaiter().GetResult();

        }
    }
}
