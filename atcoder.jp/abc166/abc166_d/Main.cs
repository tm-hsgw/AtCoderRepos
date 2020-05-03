using System;
using System.Collections.Generic;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());

            int p = 0;
            var pow = new List<long>();
            for(int i=0; i<120; i++){
                pow.Add((long) Math.Pow(i, 5));
                if(pow[i]<x) p++; 
            }

            for(int i=0; i<120; i++){
                long d = Math.Abs(pow[i]-x);
                for(int j=0; j<120; j++){
                    if(pow[j]==d){
                        if(pow[i]<x) j *= -1;
                        Console.WriteLine("{0} {1}", i, j);
                        return;
                    }
                }
            }
        }
    }
}
