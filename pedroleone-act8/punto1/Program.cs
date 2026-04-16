using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _8._1
{
    class Program
    {
        /*
         * 1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
            del vector.
         */

        private int[] Numeros;
        public void Carga()
        {
            Numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                string valor;
                valor = Console.ReadLine();
                Numeros[i] = int.Parse(valor);
            }
        }
        public void Validacion()
        {
            int menor = Numeros[0];
            int repetido = 0;
            for (int i = 1; i < Numeros.Length; i++)
            {
                if (Numeros[i] < menor)
                {
                    menor = Numeros[i];
                }
            }
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == menor)
                {
                    repetido++;
                }
            }
            Console.WriteLine("el número menor del vector es: " + menor);
            if (repetido > 1)
            {
                Console.WriteLine("el número se repite en el vector.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.Validacion();
        }
    }
}