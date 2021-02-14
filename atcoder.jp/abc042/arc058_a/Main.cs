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
//         var line = Console.ReadLine().Split(' ');

//         int f = 0;
//         int s = 0;

//         for(int i=0; i<line.Length; i++){
//             switch(line[i]){
//                 case "5":
//                 f++;
//                 continue;
//                 case "7":
//                 s++;
//                 continue;
//                 default:
//                 return "NO";
//             }
//         }
//         return f == 2 && s == 1 ? "YES" : "NO";
//     }
// }

// class B{
//     public static string Solve(){
//         var line = Console.ReadLine().Split(' ');
//         int n = int.Parse(line[0]);
//         int l = int.Parse(line[1]);

//         var stAry = new string[n];

//         for(int i=0; i<n; i++){
//             stAry[i] = Console.ReadLine();
//         }

//         Array.Sort(stAry);

//         var sb = new StringBuilder();
//         for(int i=0; i<n; i++){
//             sb.Append(stAry[i]);
//         }
//         return sb.ToString();
//     }
// }


class C{
    public static string Solve(){
        var line = Console.ReadLine().Split(' ');
        int n = int.Parse(line[0]);
        int k = int.Parse(line[1]);

        line = Console.ReadLine().Split(' ');
        var d = new HashSet<string>();
        // for(int i=0; i<10; i++) d.Add(i.ToString());
        for(int i=0; i<k; i++) d.Add(line[i]);

        for(int i=n; i<=99999; i++){
            if(IsHated(i, d)) continue;
            return i.ToString();
        }
        return null;
    }

    static bool IsHated(int i, HashSet<string> d){
        string v = i.ToString();
        foreach(string s in d){
            if(v.Contains(s)) return true;
        }
        return false;
    }
}

// class P{
//     public static string Solve(){

//     }
// }

