using System;

namespace Ejercicio2
{
    class Program
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.
        */
        private string[] nombres;
        private int[] ventas;

        public void Cargar()
        {
            nombres = new string[5];
            ventas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ventas: ");
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (ventas[i] < ventas[j])
                    {
                        int auxVenta = ventas[i];
                        ventas[i] = ventas[j];
                        ventas[j] = auxVenta;

                        string auxNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNombre;
                    }
                }
            }

            Console.WriteLine("Lista ordenada:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + " - " + ventas[i]);
            }

            Console.WriteLine("El que menos vendió: " + nombres[4] + " - " + ventas[4]);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Ordenar();
        }
    }
}