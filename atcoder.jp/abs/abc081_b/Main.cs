using System;
class Program{
  static void Main(string[] args){
    
    int N = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split(' ');
    
    int[] number = new int[N];
    for(int i=0; i<N; i++) number[i] = int.Parse(input[i]);
    
    int ans = 0;
    int fin = 0;
    
    while(fin==0){
        for(int k=0; k<number.Length; k++){
            fin = number[k]%2;
            
            if(fin==1) break;
            number[k] /= 2;
        }
      if(fin==0) ans++;
    }
    
    Console.WriteLine(ans);
  }
}