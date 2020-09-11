using System;

class MainClass {
  public static void Main (string[] args) {

  Console.Write("Ingrese un número del 1 al 5: ");
  int num = int.Parse(Console.ReadLine());


  switch(num)
  {
    case 1:
      Console.WriteLine("uno");
      break;
    case 2:
      Console.WriteLine("dos");
      break;
    case 3:
      Console.WriteLine("tres");
      break;
    case 4:
      Console.WriteLine("cuatro");
      break;
    case 5:
      Console.WriteLine("cinco");
      break;
    default:
      Console.WriteLine("error");
      break;
  }
  
  
  


  }
}