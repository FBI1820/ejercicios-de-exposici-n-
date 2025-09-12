using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_3_s3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionCordobas;
            do
            {
                Console.WriteLine("Que Cantidad desea retirar?");
                Console.WriteLine("1.C$100");
                Console.WriteLine("2.C$200");
                Console.WriteLine("3.C$500");
                Console.WriteLine("4.C$800");
                Console.WriteLine("5.C$1000");
                Console.WriteLine("6.Otra Cantidad");
                opcionCordobas = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opcionCordobas))
                {
                    Console.WriteLine("Por favor ingrese una cantidad válida.");
                }
            } while (string.IsNullOrWhiteSpace(opcionCordobas));

            Console.WriteLine("Retirando C$" + opcionCordobas);
            Console.WriteLine("Por favor, tome su dinero.");
        
        }
    }
}
