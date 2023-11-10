

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacion
{
    internal class Program
    {



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Registrar Producto");
                Console.WriteLine("2. Asignar Código de Barras");
                Console.WriteLine("3. Registrar Venta");
                Console.WriteLine("4. Salir");

                Console.Write("Elija una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarProducto();
                        break;
                    case "2":
                        AsignarCodigoDeBarras();
                        break;
                    case "3":
                        RegistrarVenta();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void RegistrarProducto()
        {
            // Implementa la lógica para registrar un producto aquí
            Console.WriteLine("Lógica para registrar un producto");
        }

        static void AsignarCodigoDeBarras()
        {
            // Implementa la lógica para asignar un código de barras aquí
            Console.WriteLine("Lógica para asignar un código de barras");
        }

        static void RegistrarVenta()
        {
            // Implementa la lógica para registrar una venta aquí
            Console.WriteLine("Lógica para registrar una venta");
        }
    }

}