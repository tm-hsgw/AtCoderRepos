using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        string[] input = Console.ReadLine().Split(' ');
        
        int n = int.Parse(input[0].ToString());
        int a = int.Parse(input[1].ToString());
        int b = int.Parse(input[2].ToString());
        
        if(n*a <= b) Console.WriteLine(n*a);
        else Console.WriteLine(b);
    }
}