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
//         long x = long.Parse(Console.ReadLine());
//         x = (100 - (x % 100));
//         return x.ToString();
//     }
// }

class B{
    public static string Solve(){
        string s = Console.ReadLine();
        for(int i=0; i<s.Length; i++){
            if(i%2==0){
                if(char.IsUpper(s[i])) return "No";
                continue;
            }
            if(char.IsUpper(s[i])) continue;
            return "No";
        }
        return "Yes";
    }
}
