using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class Program
    {
        /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
        ordenado de menor a mayor y de mayor a menor.
        */
        private int[] v1;
        public void Cargar()
        {
            v1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa un valor: ");
                string ingresado;
                ingresado = Console.ReadLine();
                v1[i] = int.Parse(ingresado);
            }
        }
        public void Verificacion()
        {
            int Esmayor = 0;
            int Esmenor = 0;
            for (int i = 0; i < v1.Length - 1; i++)
            {
                if (v1[i] <= v1[i + 1])
                {
                    Esmenor++;
                }
                if (v1[i] >= v1[i + 1])
                {
                    Esmayor++;
                }
            }
            if (Esmenor == v1.Length - 1)
            {
                Console.WriteLine("el vector esta ordenado de menor a mayor");
            }
            else if (Esmayor == v1.Length - 1)
            {
                Console.WriteLine("el vector esta ordenado de mayor a menor");
            }
            else
            {
                Console.WriteLine("El vector no esta ordenado de ninguna forma");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Verificacion();
        }
    }
}