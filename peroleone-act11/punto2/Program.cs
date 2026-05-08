using System;

namespace Ejercicio2
{
    class MatrizIrregular
    {
        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
          primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
          (crearla sin la intervención del operador)
          Realizar la carga por teclado e imprimir posteriormente.
        */
        private int[][] matriz;
        public void Crear()
        {
            matriz = new int[5][];

            for (int f = 0; f < 5; f++)
            {
                matriz[f] = new int[f + 1];
            }
        }
        public void Cargar()
        {
            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write("Ingrese valor [" + f + "," + c + "]: ");
                    matriz[f][c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Matriz irregular:");

            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write(matriz[f][c] + " ");
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MatrizIrregular m = new MatrizIrregular();

            m.Crear();
            m.Cargar();
            m.Mostrar();

            Console.ReadKey();
        }
    }
}