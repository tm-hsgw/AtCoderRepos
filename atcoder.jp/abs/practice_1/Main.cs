using System;
class Program{
  static void Main(string[] args){
    
    int a = int.Parse(Console.ReadLine());
    string[] inputLine02 = Console.ReadLine().Split(' ');
    int b = int.Parse(inputLine02[0]);
    int c = int.Parse(inputLine02[1]);
    
    string s = Console.ReadLine();
    
    Console.WriteLine("{0} {1}",a+b+c,s);
  }
}