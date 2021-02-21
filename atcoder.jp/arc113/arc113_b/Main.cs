using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program{
    static void Main(string[] args){
        Console.WriteLine(B.Solve());
    }
}

// class A{
//     public static string Solve(){
//         long k = long.Parse(Console.ReadLine());

//         long ans = 0;
//         for(long a=1; a<=k; a++){
//             bool bn = true;
//             for(long b=a; b<=k; b++){
//                 bool cn = true;
//                 for(long c=b; c<=k; c++){
//                     int p = 6;
//                     int s = 1;
//                     if(a == b) s++;
//                     if(b == c) s++;
//                     if(c == a) s++;
//                     if(s == 4) s--;

//                     if(a*b*c <= k){
//                         cn = false;
//                         for(; s>1; s--) p /= s;
//                         ans += p;
//                         continue;
//                     }
//                     break;
//                 }
//                 if(cn) break;
//                 bn = false;
//             }
//             if(bn) break;
//         }
//         return ans.ToString();
//     }
// }

class B{
    public static string Solve(){
        long[] d = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long a = d[0] % 10;
        long b = d[1] % 4;
        long c = d[2] % 4;

        int bc = 0;
        if(b == 0) bc = 4;
        if(b == 1) bc = 1;
        if(b == 2){
            if(c == 1) bc = 2;
            else bc = 4; 
        }
        if(b == 3){
            bc = 3;
            if(c % 2 == 0) bc = 1;
        }

        long aa = 1;
        for(int i=0; i<bc; i++) aa *= a;
        aa = aa % 10;

        return aa.ToString();
    }
}