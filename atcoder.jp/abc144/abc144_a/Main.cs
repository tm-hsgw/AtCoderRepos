using System;
public class Hello{
    public static void Main(){
        // Your code here!
        string[] line = Console.ReadLine().Split(' ');
        
        int a = int.Parse(line[0]);
        int b = int.Parse(line[1]);
        
        if(1<=a && a<=9 && 1<=b && b<=9) Console.WriteLine(a*b);
        else Console.WriteLine("-1");
    }
}
