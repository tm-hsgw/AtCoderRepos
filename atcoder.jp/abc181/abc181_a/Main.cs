using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "White" : "Black");
        }
    }
}
