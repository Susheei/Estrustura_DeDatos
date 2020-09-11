using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Indique el primer número: ");
            int valor1 = int.Parse(Console.ReadLine());
           
            Console.Write("Indique el segundo número: ");
            int valor2 = int.Parse(Console.ReadLine());

            if((valor2 ) > 0)
                Console.WriteLine("El resultado es: "+ valor1/valor2);
              else
                Console.WriteLine("Error! no se puede dividir entre 0");
        }
    }
}