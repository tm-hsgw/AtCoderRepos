using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] ary = new int[n];
        
        for(int i=0; i<n; i++){
            ary[i] = int.Parse(input[i]);
        }
        
        Array.Sort(ary);
        
        int ans = ary[n/2] - ary[n/2-1];
        
        Console.WriteLine(ans);
    }
}