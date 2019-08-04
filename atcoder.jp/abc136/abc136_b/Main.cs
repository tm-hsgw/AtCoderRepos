using System;
public class A009{
    public static void Main(){
        int n = int.Parse(Console.ReadLine());
        
        int ans = 0;
        
        if(10<=n) ans += 9;
        else{
            Console.WriteLine(n);
            return;
        }
        
        if(1000<=n) ans += 900;
        else{
            if(99<=n) ans += n-99;
            Console.WriteLine(ans);
            return;
        }
        
        if(100000<=n) ans += 90000;
        else if(9999<=n) ans += n-9999;
        
        Console.WriteLine(ans);
    }
}