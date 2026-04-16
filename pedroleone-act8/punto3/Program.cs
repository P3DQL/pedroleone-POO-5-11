using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        /*
         * 3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            (el orden lo pueden elegir ustedes).
        */
        private int[] V1;
        public void Carga()
        {
            V1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingresa un número: ");
                String valor;
                valor = Console.ReadLine();
                V1[i] = int.Parse(valor);
            }
        }
        public void Orden()
        {
            for (int i = 0; i < V1.Length - 1; i++)
            {
                for (int j = 0; j < V1.Length - 1 - i; j++)
                {
                    if (V1[j] > V1[j + 1])
                    {
                        int aux = V1[j];
                        V1[j] = V1[j + 1];
                        V1[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Ordenado de menor a mayor: ");
            for (int i = 0; i < V1.Length; i++)
            {
                Console.Write(V1[i] + (" "));
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.Orden();
        }
    }
}