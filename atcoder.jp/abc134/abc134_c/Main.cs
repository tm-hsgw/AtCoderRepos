using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        int n = int.Parse(Console.ReadLine());
        int[] seq = new int[n];
        
        for(int i=0; i<n; i++){
            seq[i] = int.Parse(Console.ReadLine());
        }
        
        int[] sortSeq = new int[n];
        Array.Copy(seq, sortSeq, n);
        Array.Sort(sortSeq);
        
        if(sortSeq[n-1] == sortSeq[n-2]){
            for(int k=0; k<n; k++) Console.WriteLine(sortSeq[n-1]);
        }
        else{
            int index1st = Array.IndexOf(seq, sortSeq[n-1]);
            for(int l=0; l<n; l++){
                if(l==index1st) Console.WriteLine(sortSeq[n-2]);
                else Console.WriteLine(sortSeq[n-1]);
            }
        }
    }
}