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
        long x = long.Parse(Console.ReadLine());
        x = (100 - (x % 100));
        return x.ToString();
    }
}