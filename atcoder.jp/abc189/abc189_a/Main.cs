using System;
class Program{
  static void Main(){
    var s = Console.ReadLine();
    Console.WriteLine(s[0]==s[1] && s[1]==s[2] ? "Won" : "Lost");
  }
}