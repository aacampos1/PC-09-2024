using System;
using System.Collections.Generic;
class Programa
{
    static void Main()
    {
        string[] nombres = new string[10];
        int[] notas = new int[10];

        for (int i = 0; i < 10; i++)
        {
            do
            {
                Console.Write($"Ingrese nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese nota del estudiante {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100);

            Console.WriteLine();
        }

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menu:\n1) insertar aprobados\n2) Mostrar no aprobados\n3) Promedio de notas\n4) Salir");
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Mostrar(nombres, notas, true);
                        break;
                    case 2:
                        Mostrar(nombres, notas, false);
                        break;
                    case 3:
                        Console.WriteLine($"Promedio: {notas.Average()}");
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }

    static void Mostrar(string[] nombres, int[] notas, bool aprobados)
    {
        string mensaje = aprobados ? "Aprobados" : "No Aprobados";
        Console.WriteLine($"Alumnos {mensaje}:");
        for (int i = 0; i < 10; i++)
        {
            if ((aprobados && notas[i] >= 65) || (!aprobados && notas[i] < 65))
                Console.WriteLine($"Nombre: {nombres[i]}, Nota: {notas[i]}");
                
        }
    }
}