using System;
using System.Collections.Generic;
using System.Linq;

namespace abc094_c
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var x = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] c = new long[n];
            x.CopyTo(c, 0);

            Array.Sort(x);

            long mi1 = n / 2;
            long mi2 = mi1 - 1;
            double med = (x[mi1] + x[mi2]) / 2d;

            for(int i=0; i<n; i++){
                Console.WriteLine(c[i] < med ? x[mi1] : x[mi2]);
            }

        }
    }
}
