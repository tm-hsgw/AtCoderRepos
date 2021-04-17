using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JSC2021
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(C.Solve());
        }
    }

    // class A{
    //     public static string Solve(){
    //         double[] line = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
    //         double tmp = line[1] / line[0] * line[2];
    //         int ans = (int)tmp;
    //         if(tmp - ans < double.Epsilon) ans--;
    //         return ans.ToString();
    //     }
    // }

    // class B{
    //     public static string Solve(){
    //         int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //         int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //         int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    //         var inter = a.Intersect(b);
    //         var union = a.Union(b);
    //         var xor = union.Except(inter).ToList();
    //         xor.Sort();
            
    //         return string.Join(' ', xor);   
    //     }
    // }

    class C{
        public static string Solve(){
            long[] ab = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            for(long m = ab[1] - ab[0]; m > 0; m--){
                long d = m * (long)Math.Ceiling(ab[0] / (double)m);
                if(ab[0] <= d && d + m <= ab[1]) return m.ToString();
            }
            return "1";
        }
    }
}