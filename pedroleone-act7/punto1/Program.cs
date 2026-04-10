using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        El valor acumulado de todos los elementos del vector.
        El valor acumulado de los elementos del vector que sean mayores a 36.
        Cantidad de valores mayores a 50.
        */
        private int[] valores;
        public void Cargar()
        {
            valores = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese un valor: ");
                string ingresado;
                ingresado = Console.ReadLine();
                valores[i] = int.Parse(ingresado);
            }
        }
        public void verify_and_print()
        {
            Console.Write("Elementos del vector: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(valores[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Elementos del vector mayores a 36: ");
            foreach (int f in valores)
            {
                if (f > 36)
                {
                    Console.Write(f + " ");
                }
                else
                {
                }
            }
            Console.WriteLine();
            Console.Write("Elementos del vector mayores a 50: ");
            foreach (int x in valores)
            {
                if (x > 50)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.verify_and_print();
        }
    }
}