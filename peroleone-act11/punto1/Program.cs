using System;

namespace Ejercicio1
{
    class Temperaturas
    {
        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
        dato las temperaturas medias mensuales de dichos paises.
        Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
        mensuales.
        Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
        memoria.
        a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
        b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
        mismas.
        c. Calcular la temperatura media trimestral de cada país.
        d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
        e. Imprimir el nombre del país con la temperatura media trimestral mayor.
        */
        private string[] paises = new string[4];
        private int[,] temperaturas = new int[4, 3];
        private int[] promedios = new int[4];

        public void Cargar()
        {
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese nombre del país: ");
                paises[f] = Console.ReadLine();

                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Ingrese temperatura del mes " + (c + 1) + ": ");
                    temperaturas[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Países y temperaturas:");

            for (int f = 0; f < 4; f++)
            {
                Console.Write(paises[f] + ": ");

                for (int c = 0; c < 3; c++)
                {
                    Console.Write(temperaturas[f, c] + " ");
                }

                Console.WriteLine();
            }
        }

        public void CalcularPromedios()
        {
            for (int f = 0; f < 4; f++)
            {
                int suma = 0;

                for (int c = 0; c < 3; c++)
                {
                    suma += temperaturas[f, c];
                }

                promedios[f] = suma / 3;
            }
        }

        public void MostrarPromedios()
        {
            Console.WriteLine("Promedios trimestrales:");

            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine(paises[f] + ": " + promedios[f]);
            }
        }

        public void MayorPromedio()
        {
            int pos = 0;

            for (int f = 1; f < 4; f++)
            {
                if (promedios[f] > promedios[pos])
                {
                    pos = f;
                }
            }

            Console.WriteLine("País con mayor promedio: " + paises[pos]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperaturas t = new Temperaturas();

            t.Cargar();
            t.Mostrar();
            t.CalcularPromedios();
            t.MostrarPromedios();
            t.MayorPromedio();

            Console.ReadKey();
        }
    }
}