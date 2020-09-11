using System;

class MainClass {
  public static void Main (string[] args) {
    
    int a = 5;
    int b = 0;
    int c = 0;

    b = a + 2;
    Console.WriteLine("b=a+2: "+b);  

    b -= 3;
    Console.WriteLine("b-=3: "+b);  

    c = -3;
    Console.WriteLine("c=-3: "+c);  

    a *= 2;
    Console.WriteLine("c*=2: "+a);  

    ++c;
    Console.WriteLine("++c: "+c);

    a *= b;
    Console.WriteLine("a*=b: "+a);

  }
}