using System;
class Program{
  static void Main(string[] args){
    
    string[] input = Console.ReadLine().Split(' ');
    
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    
    if(a*b%2==1) Console.WriteLine("Odd");
    else Console.WriteLine("Even");
    
  }
}