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
//         long x = long.Parse(Console.ReadLine());
//         x = (100 - (x % 100));
//         return x.ToString();
//     }
// }

// class B{
//     public static string Solve(){
//         string s = Console.ReadLine();
//         for(int i=0; i<s.Length; i++){
//             if(i%2==0){
//                 if(char.IsUpper(s[i])) return "No";
//                 continue;
//             }
//             if(char.IsUpper(s[i])) continue;
//             return "No";
//         }
//         return "Yes";
//     }
// }

class C{
    public static string Solve(){
        string[] line = Console.ReadLine().Split(' ');
        long n = long.Parse(line[0]);
        long k = long.Parse(line[1]);

        for(int i=0; i<k; i++){
            var c = n.ToString().ToCharArray();
            Array.Sort(c);
            var g1 = long.Parse(new string(c));
            Array.Reverse(c);
            var g2 = long.Parse(new string(c));
            n = g2 - g1;
        }
        return n.ToString();
    }
}
