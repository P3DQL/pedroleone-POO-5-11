using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        /*
         * 2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
            algoritmo de ordenamiento alfabético.
        */
        private String[] v1;
        public void Carga()
        {
            v1 = new String[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingresa el nombre de un pais: ");
                v1[i] = Console.ReadLine();
            }
        }
        public void OrdenA_Z()
        {
            for (int i = 0; i < v1.Length - 1; i++)
            {
                for (int j = 0; j < v1.Length - 1 - i; j++)
                {
                    if (v1[j].CompareTo(v1[j + 1]) > 0)
                    {
                        String aux = v1[j];
                        v1[j] = v1[j + 1];
                        v1[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Ordenado alfabeticamente: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write(v1[i] + (" "));
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.OrdenA_Z();
        }
    }
}