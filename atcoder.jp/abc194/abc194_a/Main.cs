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
        int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        if(ab[0] + ab[1] >= 15 && ab[1] >= 8) return "1";
        if(ab[0] + ab[1] >= 10 && ab[1] >= 3) return "2";
        if(ab[0] + ab[1] >= 3) return "3";
        return "4";
    }
}
