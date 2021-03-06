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
//         int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//         if(ab[0] + ab[1] >= 15 && ab[1] >= 8) return "1";
//         if(ab[0] + ab[1] >= 10 && ab[1] >= 3) return "2";
//         if(ab[0] + ab[1] >= 3) return "3";
//         return "4";
//     }
// }

// class B{
//     public static string Solve(){
//         int n = int.Parse(Console.ReadLine());
//         var a = new List<int>(n + 1);
//         var b = new List<int>(n + 1);
//         int a1 = 0;
//         int a2 = 0;
//         int b1 = 0;
//         int b2 = 0;
//         a.Add(int.MaxValue);
//         b.Add(int.MaxValue);
//         for(int i=1; i<=n; i++){
//             var line = Console.ReadLine().Split(' ');
//             int na = int.Parse(line[0]);
//             if(na < a[a1]){
//                 a2 = a1;
//                 a1 = i;
//             }
//             else if(na < a[a2]) a2 = i;
//             a.Add(na);

//             int nb = int.Parse(line[1]);
//             if(nb < b[b1]){
//                 b2 = b1;
//                 b1 = i;
//             }
//             else if(nb < b[b2]) b2 = i;
//             b.Add(nb);
//         }

//         if(a1 != b1) return Max(a[a1], b[b1]).ToString();

//         int[] s = {a[a1] + b[b1], Max(a[a2], b[b1]), Max(a[a1], b[b2])};
//         return s.Min().ToString();
//     }
//     static int Max(int a, int b){
//         return a > b ? a : b;
//     }
// }

class C{
    public static string Solve(){
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        long[] c = new long[401];

        for(int i=0; i<n; i++) c[a[i] + 200]++;

        long ans = 0;
        for(int i=0; i<400; i++){
            for(int j=i+1; j<=400; j++){
                ans += c[i] * c[j] * (i - j) * (i - j);
            }
        }

        return ans.ToString();
    }
}
