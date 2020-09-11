using System;

class MainClass {
  public static void Main (string[] args) {

            Console.WriteLine(" Ingrese su nombre ");
             Console.ReadLine();

            Console.WriteLine(" Ingrese la contraseña ");
          string Password1 = Console.ReadLine();

            Console.WriteLine(" Ingrese la contraseña de nuevo ");
          string Password_valid = Console.ReadLine();


       while (Password1 != Password_valid)
            {
                Console.WriteLine(" Error! Las contraseñas no coinciden ");
                
                Console.WriteLine(" Vuelva a ingresar la contraseña ");
                  Password1 = Console.ReadLine();

                Console.WriteLine(" Repita la contraseña ");
                  Password_valid = Console.ReadLine();

            }
      
            Console.WriteLine(" Bienvenido! ");


    }



  }
