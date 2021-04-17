using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JSC2021
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(A.Solve());
        }
    }

    class A{
        public static string Solve(){
            double[] line = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double tmp = line[1] / line[0] * line[2];
            int ans = (int)tmp;
            if(tmp - ans < double.Epsilon) ans--;
            return ans.ToString();
        }
    }
}