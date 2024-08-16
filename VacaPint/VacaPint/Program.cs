using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacaPint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList lista = new LinkedList();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("----- Lista Enlazada -----");
                Console.WriteLine("1. Insertar elemento en la lista");
                Console.WriteLine("2. Eliminar elemento por posición");
                Console.WriteLine("3. Encontrar nodo medio");
                Console.WriteLine("4. Mostrar lista");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor a insertar: ");
                        int valorInsertar = int.Parse(Console.ReadLine());
                        lista.InsertarFinal(valorInsertar);
                        Console.WriteLine("Elemento insertado.");
                        break;

                    case 2:
                        Console.Write("Ingrese la posición del elemento a eliminar: ");
                        int posicionEliminar = int.Parse(Console.ReadLine());
                        lista.EliminarPorPosicion(posicionEliminar);
                        Console.WriteLine("Elemento eliminado.");
                        break;

                    case 3:
                        lista.EncontrarNodoMedio();
                        break;

                    case 4:
                        Console.WriteLine("Elementos en la lista:");
                        lista.Mostrar();
                        break;

                    case 5:
                        Console.WriteLine("Salir del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 5);
        }
    }
}
