using System;

class MainClass{
  
  public static void Main (string[] args) {
  
    int elinicio =0;
    
    Console.WriteLine("Ingrese un número: ");
    int num_positivo = Int32.Parse(Console.ReadLine());

      while(num_positivo > 0){

        num_positivo = num_positivo/10;
        elinicio++;

         }
      

    
         Console.WriteLine("La cantidad de cifras es: " + num_positivo + elinicio);

 
  } 
    
  
}
