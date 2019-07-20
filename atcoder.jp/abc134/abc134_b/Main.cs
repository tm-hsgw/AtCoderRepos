using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        string[] input = Console.ReadLine().Split(' ');
        
        double n = double.Parse(input[0]);
        double d = double.Parse(input[1]);
        
        d *= 2;
        d++;
        
        double div = n/d;
        
        int ans = (int)div;
        
        if(div-(int)div > 0) ans++;
        
        Console.WriteLine(ans);
    }
}