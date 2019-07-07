using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        
        int N = int.Parse(Console.ReadLine());
        int[] t = new int[N+1];
        int[] x = new int[N+1];
        int[] y = new int[N+1];
        
        t[0] = 0;
        x[0] = 0;
        y[0] = 0;
        
        int fin=0;
        
        for(int i=1; i<=N; i++){
            string[] input = Console.ReadLine().Split(' ');
            
            if(fin!=0) break;
            t[i] = int.Parse(input[0].ToString());
            x[i] = int.Parse(input[1].ToString());
            y[i] = int.Parse(input[2].ToString());
            
            int dT = t[i] - t[i-1];
            int dX = x[i] - x[i-1];
            int dY = y[i] - y[i-1];
            
            int ndX = dX;
            int ndY = dY;
            if(ndX<0) ndX *= -1;
            if(ndY<0) ndY *= -1;
            
            //経過時間より移動量のほうが大きければ終了
            if(dT<ndX+ndY){
                if(fin==0) Console.WriteLine("No");
                fin++;
                break;
            }
            
            //経過時間と移動量の奇偶が一致しなければ終了
            if(dT%2 != (ndX+ndY)%2){
                if(fin==0) Console.WriteLine("No");
                fin++;
                break;
            }
            
            //経過時間と移動量が一致すれば次の時刻へ
            //if(dT == ndX+ndY) break;
            
            //while(true){
                //dT -= 2;
                //if(dT == ndX+ndY) break;
                //if(dT<0){
                //    if(fin==0) Console.WriteLine("No");
                //    fin++;
                //    break;
            //    }
            //}
        }
        
        if(fin==0) Console.WriteLine("Yes");
        
    }
}