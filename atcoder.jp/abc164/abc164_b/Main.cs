using System;
public class Hello{
    public static void Main(){
        // Your code here!
        string[] line = Console.ReadLine().Split(' ');
        double a = int.Parse(line[0]);
        double b = int.Parse(line[1]);
        double c = int.Parse(line[2]);
        double d = int.Parse(line[3]);
        double ta = Math.Ceiling(c/b);
        double ao = Math.Ceiling(a/d);

        Console.WriteLine(ta<=ao ? "Yes" : "No");
    }
}
