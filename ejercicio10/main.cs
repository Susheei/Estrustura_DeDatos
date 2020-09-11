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
          
            Console.Write("Indique el numero: ");
            double valor = double.Parse(Console.ReadLine());

            if((valor % 2) == 0)
                Console.WriteLine("Es Par");
              else
                Console.WriteLine("Es Impar");
        }
    }
}