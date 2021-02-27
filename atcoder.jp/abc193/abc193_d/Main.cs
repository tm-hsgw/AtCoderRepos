using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program{
    static void Main(string[] args){
        Console.WriteLine(D.Solve());
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

// class C{
//     public static string Solve(){
//         long n = long.Parse(Console.ReadLine());

//         if(n <= 3) return n.ToString();

//         double sq = Math.Sqrt(n);

//         var hs = new HashSet<long>();
//         for(int a=2; a<=sq; a++){
//             if(Math.Pow(a, 2) > n) break;
//             for(int b=2; b<n; b++){
//                 long tmp = (long)Math.Pow(a, b);
//                 if(tmp > n) break;
//                 hs.Add(tmp);
//             }
//         }
//         return (n - hs.Count).ToString();
//     }
// }

class D{
    public static string Solve(){
        long k = long.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var t = Console.ReadLine();

        var tk = Score(s);
        var ao = Score(t);

        double denom = (k * 9d - 8) * (k * 9d - 9);
        long[] ct = new long[10];

        for(int i=1; i<=9; i++){
            ct[i] = s.Length - s.Replace(i.ToString(), "").Length;
            ct[i] += t.Length - t.Replace(i.ToString(), "").Length;
            ct[i] = k - ct[i];
        }

        double numer = 0;
        for(int i=1; i<=9; i++){
            for(int j=1; j<=9; j++){
                if(tk[i] > ao[j]){
                    numer += ct[i] * (double)ct[j];
                    if(i == j) numer -= ct[i];
                }
            }
        }

        return (numer / denom).ToString();
    }

    static IReadOnlyList<double> Score(string str){
        double[] score = new double[10];
        for(int i=1; i<=9; i++){
            string s = str.Remove(4, 1).Insert(4, i.ToString());
            score[i] = 0;

            for(int c=1; c<=9; c++){
                int ci = s.Length - s.Replace(c.ToString(), "").Length;
                score[i] += c * Math.Pow(10, ci);
            }
        }

        return score;
    }
}