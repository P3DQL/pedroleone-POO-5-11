using System;

namespace Ejercicio2
{
    class Matriz
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
        */
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

        public void IntercambiarFilas()
        {
            for (int c = 0; c < columnas; c++)
            {
                int aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Matriz:");

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matriz m = new Matriz();
            m.Cargar();
            m.IntercambiarFilas();
            m.Mostrar();
            Console.ReadKey();
        }
    }
}