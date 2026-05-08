using System;

namespace Ejercicio3
{
    class Empresa
    {
        /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
             empresa.
             Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
             irregular para cargar los días que han faltado cada empleado (cargar el número de día que
             faltó)
             Cada fila de la matriz representa los días de cada empleado.
             a. Mostrar los empleados con la cantidad de inasistencias.
             b. Cuál empleado faltó menos días.
        */
        private string[] empleados = new string[3];
        private int[][] faltas = new int[3][];
        public void Cargar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                empleados[i] = Console.ReadLine();

                Console.Write("Cantidad de inasistencias: ");
                int cantidad = int.Parse(Console.ReadLine());

                faltas[i] = new int[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write("Ingrese día de falta: ");
                    faltas[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void MostrarInasistencias()
        {
            Console.WriteLine("Cantidad de inasistencias:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(empleados[i] + ": " + faltas[i].Length);
            }
        }
        public void EmpleadoMenosFaltas()
        {
            int pos = 0;

            for (int i = 1; i < 3; i++)
            {
                if (faltas[i].Length < faltas[pos].Length)
                {
                    pos = i;
                }
            }
            Console.WriteLine("Empleado con menos faltas: " + empleados[pos]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Empresa e = new Empresa();

            e.Cargar();
            e.MostrarInasistencias();
            e.EmpleadoMenosFaltas();

            Console.ReadKey();
        }
    }
}