using System;
class Program{
  static void Main(string[] args){
      
      string[] input = Console.ReadLine().Split(' ');
      
      int N = int.Parse(input[0]); 
      int A = int.Parse(input[1]); 
      int B = int.Parse(input[2]); 
      
      int ans = 0;
      
      for(int i=1; i<=N; i++){
          
          int k = i;
          int sum = 0;
          
          while(true){
              sum += k%10;
              if(k<10) break;
              k -= k%10;
              k /= 10;
          }
          
          if(A<=sum && sum<=B) ans += i;
          
      }
      
      Console.WriteLine(ans);
      
  }
}