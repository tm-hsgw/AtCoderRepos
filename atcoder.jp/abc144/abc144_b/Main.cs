using System;
public class Hello{
    public static void Main(){
        // Your code here!
        int n = int.Parse(Console.ReadLine());
        
        for(int i=1; i<=9; i++){
            for(int j=1; j<=9; j++){
                if(n == i*j){
                    Console.WriteLine("Yes");
                    return;
                }
            }
        }
        
        Console.WriteLine("No");
    }
}
