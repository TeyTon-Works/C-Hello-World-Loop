using System;
class P{
    static void Main(){
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 1;
        
        
while (a <= n) {
    Console.WriteLine($"{a}. Hello World!");
    a++;
    
}
    }
}
