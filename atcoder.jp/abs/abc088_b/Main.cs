using System;
using System.Linq;
class Program{
  static void Main(string[] args){
      
      int N = int.Parse(Console.ReadLine());
      string[] input = Console.ReadLine().Split(' ');
      int[] card = new int[N];
      
      int alice = 0;
      int bob = 0;
      
      for(int i=0; i<N; i++){
          card[i] = int.Parse(input[i]);
      }
      
      for(int j=0; j<N; j++){
          alice += card.Max();
          
          for(int k=0; k<N; k++){
              if(card[k]==card.Max()){
                  card[k] = 0;
                  break;
              }
          }
          
          j++;
          if(j==N) break;
          
          bob += card.Max();
          
          for(int l=0; l<N; l++){
              if(card[l]==card.Max()){
                  card[l] = 0;
                  break;
              }
          }
      }
      
      Console.WriteLine(alice-bob);
      
  }
}