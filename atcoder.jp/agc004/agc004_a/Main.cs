using System;
using System.Linq;

namespace agc004_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Array.Sort(l);
            long a = l[0];
            long b = l[1];
            long c = l[2];
            long ans = 0;
            if(a%2==1 && b%2==1 && c%2==1) ans = a*b;
            Console.WriteLine(ans);
        }
    }
}
