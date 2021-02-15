using System;
using System.Collections.Generic;
using System.Linq;

namespace abc189_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int ans = 0;
            for(int l=0; l<n; l++){
                int x = a[l];
                for(int r=l; r<n; r++){
                    x = a[r] > x ? x : a[r];
                    ans = x * (r - l + 1) > ans ? x * (r - l + 1) : ans;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
