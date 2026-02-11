// Version inicial}

using System;
using System.Collections.Generic;
namespace RegistroPersonas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            while (true)
            {
                Console.Write("Ingrese la cantidad de personas: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out cantidad) && cantidad >= 1)
                    break;

                Console.WriteLine("Valor inválido. Debe ser un número mayor o igual a 1.\n");
            }

            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nPersona #{i + 1}");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                int edad;
                while (true)
                {
                    Console.Write("Edad: ");
                    string inputEdad = Console.ReadLine();

                    if (int.TryParse(inputEdad, out edad))
                        break;

                    Console.WriteLine("Edad inválida. Intente nuevamente.");
                }

                edades.Add(edad);
            }

            if (cantidad == 1)
            {
                if (edades[0] >= 18)
                    Console.WriteLine($"{nombres[0]} es mayor de edad.");
                else
                    Console.WriteLine($"{nombres[0]} es menor de edad.");

                return;
            }

            Console.WriteLine("\nLista general:");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"{nombres[i]} - {edades[i]} años");
            }

            List<string> mayores = new List<string>();
            List<string> menores = new List<string>();

            for (int i = 0; i < nombres.Count; i++)
            {
                if (edades[i] >= 18)
                    mayores.Add($"{nombres[i]} - {edades[i]} años");
                else
                    menores.Add($"{nombres[i]} - {edades[i]} años");
            }

            if (mayores.Count > 0)
            {
                Console.WriteLine("\nMayores de edad:");
                foreach (var persona in mayores)
                    Console.WriteLine(persona);
            }

            if (menores.Count > 0)
            {
                Console.WriteLine("\nMenores de edad:");
                foreach (var persona in menores)
                    Console.WriteLine(persona);
            }
        }
    }
}
