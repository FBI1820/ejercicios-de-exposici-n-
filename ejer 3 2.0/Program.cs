using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_3_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea1: Menu principal 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Bienvenido al cajero automatico MF");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Por favor inserta una tarjeta bancaria :)");
            Console.WriteLine("Ya ingresastes tu tarjeta? (si/no)");
            string respuesta = Console.ReadLine();

            if (respuesta == "Si" || respuesta == "SI" || respuesta == "s")
            {
                Console.WriteLine("Por favor selecciona una opción:");
                Console.WriteLine("1. Consulta");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Deposito");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Consultas();
                        break;
                    case "2":
                        Retiro();
                        break;
                    case "3":
                        Deposito();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, inserta tu tarjeta.");

            }
            void Consultas() //Tarea 2:Consulta SOLO ES DE MUESTRA
            {
                Console.WriteLine("Realizando consulta...");
            }

            void Retiro() //Tarea 3: Retiro CON UN BREVE MENU
            {
                Console.WriteLine("En que moneda desea hacer el retiro? (C$/USD). Digita el numero de la opcion");
                Console.WriteLine("1.C$ = Córdobas");
                Console.WriteLine("2.USD = Dólares");
                string opcionmoney = Console.ReadLine();
                switch (opcionmoney)
                {
                    case "1":
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
                        break;

                    //Aqui no se si queres seguir, por que que pereza hacer la interfaz de retiro del Banpro


                    case "2":
                        string opcionDolares;
                        do
                        {
                            Console.WriteLine("Que Cantidad desea retirar?");
                            Console.WriteLine("1.$100");
                            Console.WriteLine("2.$200");
                            Console.WriteLine("3.$500");
                            Console.WriteLine("4.$800");
                            Console.WriteLine("5.$1000");
                            Console.WriteLine("6.Otra Cantidad");
                            opcionDolares = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(opcionDolares))
                            {
                                Console.WriteLine("Por favor ingrese una cantidad válida.");
                            }
                        } while (string.IsNullOrWhiteSpace(opcionDolares));

                        Console.WriteLine("Retirando $" + opcionDolares);
                        Console.WriteLine("Por favor, tome su dinero.");
                        break;
                        //Igual aqui, que pereza la verdad, o sea medio la hice en cordobas
                }
            }
            void Deposito() // Tarea 4: Deposito CON UN BREVE MENU SIMILAR AL ANTERIOR
            {
                Console.WriteLine("En que moneda desea hacer el deposito? (C$/USD). Digita el numero de la opcion");
                Console.WriteLine("1.C$ = Córdobas");
                Console.WriteLine("2.USD = Dólares");
                string opcionmoney = Console.ReadLine();
                switch (opcionmoney)
                { //Deposito de cordobas
                    case "1":

                        string opcionCordobas;
                        do
                        {
                            Console.WriteLine("Que Cantidad desea depositar?");
                            Console.WriteLine("No compartas tu informacion con nadie");
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

                        Console.WriteLine("Depositando C$" + opcionCordobas);
                        Console.WriteLine("Gracias Por usar nuestro cajero!.");
                        break;



                    case "2":
                        string opcionDolares;


                        do
                        {
                            Console.WriteLine("Que Cantidad desea depositar?");
                            Console.WriteLine("1.$100");
                            Console.WriteLine("2.$200");
                            Console.WriteLine("3.$500");
                            Console.WriteLine("4.$800");
                            Console.WriteLine("5.$1000");
                            Console.WriteLine("6.Otra Cantidad");
                            opcionDolares = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(opcionDolares))
                            {
                                Console.WriteLine("Por favor ingrese una cantidad válida.");
                            }
                        } while (string.IsNullOrWhiteSpace(opcionDolares));

                        Console.WriteLine("Depositando $" + opcionDolares);
                        Console.WriteLine("Gracias Por usar nuestro cajero!.");
                        break;

                }
            }

        }
    }
}

