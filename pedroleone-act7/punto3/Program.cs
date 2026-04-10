using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
        un videojuego. El programa debe:
         Mostrar la puntuación más alta y la más baja.
         Calcular el promedio de puntuación.
         Contar cuántas veces superó los 500 puntos.
        */
        private int[] v1;
        private float promedio;
        public void Carga()
        {
            v1 = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingresar puntaje: ");
                string carga;
                carga = Console.ReadLine();
                v1[i] = int.Parse(carga);
            }
        }
        public void PAPB()
        {
            int max = v1.Max();
            int min = v1.Min();
            Console.WriteLine("el puntaje más alto es: " + max);
            Console.WriteLine("el puntaje más bajo es: " + min);
        }
        public void Promedio()
        {
            float suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma = suma + (v1[i]);
            }
            promedio = suma / 6;
            Console.WriteLine("Promedio de puntaje: " + promedio);
        }
        public void Supera500()
        {
            int mayorde500 = 0;
            for (int i = 0; i < 6; i++)
            {
                if (v1[i] > 500)
                {
                    mayorde500++;
                }
            }

            Console.WriteLine("cantidad de veces que superó los 500 puntos: " + mayorde500);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.PAPB();
            p.Promedio();
            p.Supera500();
        }

    }
}