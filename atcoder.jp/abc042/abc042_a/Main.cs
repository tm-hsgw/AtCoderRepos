using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program{
    static void Main(string[] args){
        Console.WriteLine(A.Solve());
    }
}

class A{
    public static string Solve(){
        var line = Console.ReadLine().Split(' ');

        int f = 0;
        int s = 0;

        for(int i=0; i<line.Length; i++){
            switch(line[i]){
                case "5":
                f++;
                continue;
                case "7":
                s++;
                continue;
                default:
                return "NO";
            }
        }
        return f == 2 && s == 1 ? "YES" : "NO";
    }
}

// class B{
//     public static string Solve(){
        
//     }
// }

// class C{
//     public static string Solve(){
        
//     }
// }

// class P{
//     public static string Solve(){

//     }
// }

