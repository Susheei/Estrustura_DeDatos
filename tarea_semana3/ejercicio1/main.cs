using System;

class MainClass{
  
  public static void Main (string[] args) {
    /*
    int identi_valid = 1234;
    int pass_valid = 1111;
    */

    Console.Write("Ingrese su identificador: ");
    int identificador =Int32.Parse(Console.ReadLine());

    Console.Write("Ingrese su contraseña: ");
    int password = Int32.Parse(Console.ReadLine());

    if ((identificador)== 1234)
      Console.WriteLine("Su identificador es correcto!");
    else
    Console.WriteLine("Error: su identificador es incorrecto ");

    if((password)==1111)
      Console.WriteLine("Su contraseña es correcta!");
    else
      Console.WriteLine("Error: su contraseña es incorrecta ");

      

    












 
  } 
    
  
}
