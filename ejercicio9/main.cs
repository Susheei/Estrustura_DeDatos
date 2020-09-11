using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

         int product = 0; int numero1 = 0; int numero2 = 0; 

          Console.WriteLine("Primer Numero");
          numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Numero");
            numero2 = Int32.Parse(Console.ReadLine());

              product = numero1 * numero2;

                Console.WriteLine("El Producto es: " + product);
                Console.ReadKey();
        }
    }
}