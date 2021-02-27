using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program{
    static void Main(string[] args){
        Console.WriteLine(C.Solve());
    }
}

// class A{
//     public static string Solve(){
//         var line = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//         return (100 - (line[1] / line[0]) * 100).ToString("F3");
//     }
// }

// class B{
//     public static string Solve(){
//         int n = int.Parse(Console.ReadLine());

//         long ans = long.MaxValue;
//         bool bought = false;
//         for(int i=0; i<n; i++){
//             var line = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//             if(line[2] - line[0] > 0){
//                 if(line[1] < ans){
//                     ans = line[1];
//                     bought = true;
//                 }
//             }
//         }
//         return bought ? ans.ToString() : "-1";
//     }
// }

class C{
    public static string Solve(){
        long n = long.Parse(Console.ReadLine());

        if(n <= 3) return n.ToString();

        double sq = Math.Sqrt(n);

        var hs = new HashSet<long>();
        for(int a=2; a<=sq; a++){
            if(Math.Pow(a, 2) > n) break;
            for(int b=2; b<n; b++){
                long tmp = (long)Math.Pow(a, b);
                if(tmp > n) break;
                hs.Add(tmp);
            }
        }
        return (n - hs.Count).ToString();
    }
}