using System;
class Program{
  static void Main(string[] args){
    
    string input = Console.ReadLine();
    
    int a = int.Parse(input[0].ToString());
    int b = int.Parse(input[1].ToString());
    int c = int.Parse(input[2].ToString());
    
    Console.WriteLine(a+b+c);
    
  }
}