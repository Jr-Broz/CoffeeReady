using System;
using System.Threading;

class Program {
  
  public static void Main (string[] args) {
    
    Console.WriteLine ("Preparing your coffee!");
    
    Console.WriteLine("It will only take 5 seconds..");
    
    Thread.Sleep(5000);

    Console.WriteLine("Your coffee is ready.");
    
    }
}
