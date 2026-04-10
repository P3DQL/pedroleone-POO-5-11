using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        /*Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        tercer vector del mismo tamaño. Sumar componente a componente.
        */
        private int[] v1;
        private int[] v2;
        private int[] v3;

        public void Cargas()
        {
            v1 = new int[4];
            v2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingresa un valor para el vector n°1: ");
                string cargav1;
                cargav1 = Console.ReadLine();
                v1[i] = int.Parse(cargav1);
            }
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("ingresa un valor para el vector n°2: ");
                string cargav2;
                cargav2 = Console.ReadLine();
                v2[f] = int.Parse(cargav2);
            }
        }
        public void Sumas()
        {
            v3 = new int[4];
            Console.Write("el vector n°1 es: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(v1[i] + " ");
            }
            Console.WriteLine();
            Console.Write("el vector n°2 es: ");
            for (int x = 0; x < 4; x++)
            {
                Console.Write(v1[x] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                v3[i] = v2[i] + v1[i];
            }
        }
        public void Resultadov3()
        {

            Console.Write("La suma de los vectores 1 y 2 es: ");
            for (int z = 0; z < 4; z++)
            {
                Console.Write(v3[z] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargas();
            p.Sumas();
            p.Resultadov3();
        }
    }
}