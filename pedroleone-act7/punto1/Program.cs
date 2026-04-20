using System;

namespace _7._1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        El valor acumulado de todos los elementos del vector.
        El valor acumulado de los elementos del vector que sean mayores a 36.
        Cantidad de valores mayores a 50.
     */
    class Program
    {
        private int[] valores;

        public void Cargar()
        {
            valores = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese un valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
        }

        public void verify_and_print()
        {
            int sumaTotal = 0;
            int sumaMayores36 = 0;
            int cantidadMayores50 = 0;

            for (int i = 0; i < 8; i++)
            {
                sumaTotal += valores[i];

                if (valores[i] > 36)
                    sumaMayores36 += valores[i];

                if (valores[i] > 50)
                    cantidadMayores50++;
            }

            Console.WriteLine("Suma total: " + sumaTotal);
            Console.WriteLine("Suma mayores a 36: " + sumaMayores36);
            Console.WriteLine("Cantidad mayores a 50: " + cantidadMayores50);

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
