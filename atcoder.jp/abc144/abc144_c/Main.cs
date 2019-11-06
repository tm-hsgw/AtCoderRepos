using System;
public class Hello{
    public static void Main(){
        // Your code here!
        long n = long.Parse(Console.ReadLine());
        
        for(long i=(long)Math.Sqrt(n); i>0; i--){
            double quot = n / (double)i;
            
            if(quot-Math.Floor(quot)==0){
                Console.WriteLine(i+n/i-2);
                return;
            }
        }
    }
}
