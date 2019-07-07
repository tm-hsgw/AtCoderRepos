using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        string[] inputND = Console.ReadLine().Split(' ');
        int n = int.Parse(inputND[0].ToString());
        int d = int.Parse(inputND[1].ToString());
        
        int[,] x = new int[n,d];
        int ans = 0;
        
        for(int i=0; i<n; i++){
            string[] inX = Console.ReadLine().Split(' ');
            for(int j=0; j<d; j++) x[i,j] = int.Parse(inX[j]);
        }
        
        for(int k=0; k<n; k++){
            for(int l=k+1; l<n; l++){
                
                double dist=0;
                for(int m=0; m<d; m++) dist += Math.Pow(x[k,m] - x[l,m],2);
                dist = Math.Sqrt(dist);
                if(dist-Math.Floor(dist)==0) ans++;
                
            }
        }
        Console.WriteLine(ans);
    }
}