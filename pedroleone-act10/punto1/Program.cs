using System;

namespace Ejercicio1
{
    class Program
    {
        /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
            componentes por columna (es decir primero ingresar toda la primer
            columna, luego la segunda columna y así sucesivamente)
            Imprimir luego la matriz.
        */
        private int[,] matriz = new int[2, 5];

        public void Cargar()
        {
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese valor [" + f + "," + c + "]: ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Matriz:");

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            p.Cargar();
            p.Mostrar();
            Console.ReadKey();
        }
    }
}
