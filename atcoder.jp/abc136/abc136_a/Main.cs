using System;
public class A009{
    public static void Main(){
        string[] line = Console.ReadLine().Split(' ');
        int a = int.Parse(line[0]);
        int b = int.Parse(line[1]);
        int c = int.Parse(line[2]);
        
        if(a<b+c) Console.WriteLine(b+c-a);
        else Console.WriteLine("0");
    }
}