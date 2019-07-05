using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(string[] args){
        
        string[] input = Console.ReadLine().Split(' ');
        
        int N = int.Parse(input[0]);
        int Y = int.Parse(input[1]);
        
        int fin = 0;
        
        Y /= 1000;
        
        //   a +  b + c = N;
        // 10a + 5b + c = Y;
        
        if(Y<N){
            Console.WriteLine("-1 -1 -1");
            fin++;
        }
        else{
            if(10*N == Y){
                Console.WriteLine("{0} 0 0",N);
                fin++;
            }
            else if(5*N == Y){
                Console.WriteLine("0 {0} 0",N);
                fin++;
            }
            // 9a + 4b = Y-N;
            for(int a=0; a<N; a++){
                for(int b=0; b<N-a; b++){
                    
                    if(9*a + 4*b == Y-N){
                        int c = N - a - b;
                        if(fin==0){
                            Console.WriteLine("{0} {1} {2}",a,b,c);
                            
                        } 
                        fin++;
                    }
                }
            }
        }
        
        if(fin==0) Console.WriteLine("-1 -1 -1");
        
    }
}
        