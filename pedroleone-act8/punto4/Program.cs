using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4
{
    class Program
    {
        /*
         * 4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
            ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            nuevamente.
        */
        private String[] Paises;
        private int[] Habitantes;
        public void Carga()
        {
            Paises = new String[5];
            Habitantes = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa nombre del pais: ");
                Paises[i] = Console.ReadLine();
                Console.WriteLine("Ingresa cantidad de habitantes: ");
                String valor;
                valor = Console.ReadLine();
                Habitantes[i] = int.Parse(valor);
            }
        }
        public void Orden()
        {
            for (int i = 0; i < Paises.Length - 1; i++)
            {
                for (int j = 0; j < Paises.Length - 1 - i; j++)
                {
                    if (Paises[j].CompareTo(Paises[j + 1]) > 0)
                    {
                        String aux = Paises[j];
                        Paises[j] = Paises[j + 1];
                        Paises[j + 1] = aux;

                        int aux2 = Habitantes[j];
                        Habitantes[j] = Habitantes[j + 1];
                        Habitantes[j + 1] = aux2;
                    }
                }
            }
            Console.WriteLine("Paises ordenados alfabeticamente: ");
            for (int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine(Paises[i] + (" ") + Habitantes[i]);
            }
            for (int i = 0; i < Paises.Length - 1; i++)
            {
                for (int j = 0; j < Paises.Length - 1 - i; j++)
                {
                    if (Habitantes[j] < Habitantes[j + 1])
                    {
                        int aux2 = Habitantes[j];
                        Habitantes[j] = Habitantes[j + 1];
                        Habitantes[j + 1] = aux2;

                        String aux = Paises[j];
                        Paises[j] = Paises[j + 1];
                        Paises[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Ordenado por habitantes (mayor a menor):");
            for (int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine(Paises[i] + " " + Habitantes[i]);
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