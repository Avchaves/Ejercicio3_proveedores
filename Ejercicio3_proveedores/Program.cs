using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_proveedores
{
    internal class Program
    {
        public static string[] proveedores = { "adrian", "melani", "alondra", "damian" };
        public static string[] ciudad = { "san jose", "puntarenas", "osa", "parrita" };
        public static int[] articulos = { 1, 2, 4, 6 };
        static void Main(string[] args)

        {
            mostrarmenu();
        }

        private static void mostrarmenu()
        {
            int opcion = 0;
            Console.WriteLine("Deseas ingresar al Menú? si/no ");
            string respuesta = Console.ReadLine();

            while (respuesta == "si")
            {
                Console.Clear();
                Console.WriteLine("*******Opciones del menu*******");
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Ingresar Proveedor");
                Console.WriteLine("2. Consultar Proveedor");
                Console.WriteLine("3. Actualizar Proveedor");
                Console.WriteLine("4. Eliminar Proveedor");
                Console.WriteLine("5. Reporte Detallado");
                Console.WriteLine("6. Limpiar Proveedor");
                Console.WriteLine("7. salir ");
                Console.WriteLine("*******************************");
                opcion = int.Parse(Console.ReadLine());


                if (opcion == 1)
                {
                    Ingresarproveedor();
                }
                if (opcion == 2)
                {
                    consultarproveedor();
                }
                if (opcion == 3)
                {
                    Actualizarproveedor();
                }
                if (opcion == 4)
                {
                    Eliminarproveedor();
                }
                if (opcion == 5)
                {
                    Reporte();
                }
                if (opcion == 6)
                {
                    Limpiardatos();
                }
                else Console.WriteLine("Presione enter para volver al Menú");
                Console.ReadLine();
            }
        }
        public static void Ingresarproveedor()
        {

            int largo = proveedores.Length;
            Console.Write("Digite el nombre del proveedor: ");
            string nuevoprovedor = Console.ReadLine();
            proveedores = proveedores.Concat(new string[] { nuevoprovedor }).ToArray();
            Console.Write("Digite el nombre de la ciudad de origen: ");
            string nuevaciudad = Console.ReadLine();
            ciudad = ciudad.Concat(new string[] { nuevaciudad }).ToArray();
            Console.WriteLine("Digite la cantidad de articulos: ");
            int nuevoArticulos = int.Parse(Console.ReadLine());
            articulos = articulos.Concat(new int[] { nuevoArticulos }).ToArray();


        }
        public static void consultarproveedor()
        {
            string nombreprovedor = "";
            Boolean Existe = false;
            Console.WriteLine("Digite el nombre del proveedor");
            nombreprovedor = Console.ReadLine();
            int largo = proveedores.Length;
            if (largo == 0)
            {
                Console.WriteLine("No hay proveedores");
            }
            else
            {
                for (int i = 0; i < largo; i++)
                {
                    if (proveedores[i].Equals(nombreprovedor))
                    {
                        Console.WriteLine("La ciudad del proveedor es: " + ciudad[i]);
                        Console.WriteLine("El numero de articulos es: " + articulos[i]);
                        Existe = true;
                        break;
                    }


                }
            }

        }
        public static void Actualizarproveedor()
        {
            String nombreprovedor = "";
            Boolean Existe = false;
            Console.Write("Digite un nombre del proveedor: ");
            nombreprovedor = Console.ReadLine();
            int largo = proveedores.Length;

            for (int i = 0; i < largo; i++)
            {
                if (proveedores[i].Equals(nombreprovedor))
                {
                    Console.Clear();
                    Console.Write("Actualice el nombre Proveedor:");
                    proveedores[i] = Console.ReadLine();
                    Console.Write("Actualice la Ciudad :");
                    ciudad[i] = Console.ReadLine();
                    Console.Write("Actualice el numero de Articulos:");
                    articulos[i] = int.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }
            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("El Proveedor no existe en la lista");
            }
        }
        public static void Reporte()
        {
            Console.Clear();
            Console.WriteLine("********** Reporte de Proveedores *************");
            for (int i = 0; i < proveedores.Length; i++)
            {
                Console.WriteLine($"Nombre del proveedor: {proveedores[i]} Ciudad de Origen: {ciudad[i]} Cantidad de articulos: {articulos[i]}");
            }
            Console.WriteLine("********** Fin del reporte*************");
            Console.WriteLine("Presione enter para volver al menú");
            Console.ReadLine();
        }
        public static void Eliminarproveedor()
        {

            String nombreprovedor = "";
            Console.Write("Digite un nombre del proveedor: ");
            nombreprovedor = Console.ReadLine();
            int posicion = Array.IndexOf(proveedores, nombreprovedor);
            proveedores = proveedores.Where(n => n != proveedores[posicion]).ToArray();
            ciudad = ciudad.Where(n => n != ciudad[posicion]).ToArray();
            articulos = articulos.Where(n => n != articulos[posicion]).ToArray();


        }
        public static void Limpiardatos()
        {
            int largo = proveedores.Length;
            //for (int i = largo; i > 0;)
            while (largo > 0)
            {
                proveedores = proveedores.Where(n => n != proveedores[largo - 1]).ToArray();
                ciudad = ciudad.Where(n => n != ciudad[largo - 1]).ToArray();
                articulos = articulos.Where(n => n != articulos[largo - 1]).ToArray();
                largo = largo - 1;

            }
            Console.WriteLine("Presione enter para volver al menú");
            Console.ReadLine();


        }

    }
}
