using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Introduce tu nombre: ");
    string respuesta = Console.ReadLine();
    string nombre = "Martin";

    if(respuesta == nombre)
      Console.WriteLine("Hola");
    else
      Console.WriteLine("No te conozco");

    




  }
}