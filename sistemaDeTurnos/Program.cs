using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> turnos = new Queue<string>();
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE TURNOS");
            Console.WriteLine("1. Agregar turno");
            Console.WriteLine("2. Atender turno");
            Console.WriteLine("3. Mostrar turnos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese nombre del cliente: ");
                    string nombre = Console.ReadLine();
                    turnos.Enqueue(nombre);
                    Console.WriteLine("Turno agregado correctamente.");
                    break;

                case 2:
                    if (turnos.Count > 0)
                    {
                        string atendido = turnos.Dequeue();
                        Console.WriteLine("Atendiendo a: " + atendido);
                    }
                    else
                    {
                        Console.WriteLine("No hay turnos para atender.");
                    }
                    break;

                case 3:
                    if (turnos.Count > 0)
                    {
                        Console.WriteLine("Turnos en espera:");
                        foreach (string t in turnos)
                            Console.WriteLine(t);
                    }
                    else
                    {
                        Console.WriteLine("No hay turnos registrados.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 4);
    }
}
