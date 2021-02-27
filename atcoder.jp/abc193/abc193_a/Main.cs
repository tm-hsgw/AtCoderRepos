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
        var line = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        return (100 - (line[1] / line[0]) * 100).ToString("F3");
    }
}