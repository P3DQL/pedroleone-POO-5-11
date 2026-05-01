using System;

namespace Ejercicio3
{
    /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)
    */
    class Matriz
    {
        private int[,] matriz;
        private int filas, columnas;

        public void Cargar()
        {
            Console.Write("Ingrese filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese columnas: ");
            columnas = int.Parse(Console.ReadLine());

            matriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese valor [" + f + "," + c + "]: ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void MostrarVertices()
        {
            Console.WriteLine("Superior izquierdo: " + matriz[0, 0]);
            Console.WriteLine("Superior derecho: " + matriz[0, columnas - 1]);
            Console.WriteLine("Inferior izquierdo: " + matriz[filas - 1, 0]);
            Console.WriteLine("Inferior derecho: " + matriz[filas - 1, columnas - 1]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matriz m = new Matriz();
            m.Cargar();
            m.MostrarVertices();
            Console.ReadKey();
        }
    }
}