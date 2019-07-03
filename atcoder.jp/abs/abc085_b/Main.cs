using System;
using System.Collections.Generic;
using System.Linq;
class Program{
  static void Main(string[] args){
      
      int N = int.Parse(Console.ReadLine());
      List<int> diam = new List<int>();
      
      for(int i=0; i<N; i++){
          
          int a = int.Parse(Console.ReadLine());
          int bFlag = 0;
          
          for(int j=0; j<diam.Count; j++){
              if(a==diam[j]){
                  bFlag = 1;
                  break;
              }
          }
          
          if(bFlag == 0) diam.Add(a);
          
      }
      
      Console.WriteLine(diam.Count);
      
  }
}