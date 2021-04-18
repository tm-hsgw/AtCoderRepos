using System;
using System.Collections.Generic;
using System.Linq;

namespace ARC117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Solve());
        }
    }

    class A{
        public static string Solve(){
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = line[0];
            int b = line[1];

            var ans = new List<int>(a * b);

            for(int i=1; i<=a; i++){
                ans.Add(i);
            }
            for(int i=1; i<=b; i++){
                ans.Add(-1 * i);
            }
            int sum = ans.Sum();
            if(sum == 0) return string.Join(' ', ans);
            int idx = sum < 0 ? 0 : a;
            ans[idx] -= sum;
            return string.Join(' ', ans);
        }
    }
}