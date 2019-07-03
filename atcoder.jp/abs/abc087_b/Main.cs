using System;
class Program{
  static void Main(string[] args){
      int A = int.Parse(Console.ReadLine());
      //500円
      int B = int.Parse(Console.ReadLine());
      //100円
      int C = int.Parse(Console.ReadLine());
      //50円
      int X = int.Parse(Console.ReadLine());
      //目標
      
      int ans = 0;
      
      for(int i=0; i<=A; i++){
          if(500*i<=X){
              
              if(X==500*i){
                  ans++;
                  break;
              }
              
              for(int j=0; j<=B; j++){
                  int X100 = X - (500*i);
                  
                  if(X100==100*j){
                      ans++;
                      break;
                  }
                  
                  if(100*j<X100){
                      int X50 = X - 500*i - 100*j;
                      if(X50/50<=C) ans++;
                  }
              }
          }
      }
      
      Console.WriteLine(ans);
      
  }
}