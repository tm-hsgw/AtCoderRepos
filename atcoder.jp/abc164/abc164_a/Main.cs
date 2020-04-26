using System;
public class Hello{
    public static void Main(){
        // Your code here!
        string[] line = Console.ReadLine().Split(' ');
        string ans = int.Parse(line[0]) <= int.Parse(line[1]) ? "unsafe" : "safe";
        Console.WriteLine(ans);
    }
}
