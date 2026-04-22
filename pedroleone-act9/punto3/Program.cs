using System;

namespace Ejercicio3
{
    class Program
    {
        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.
        */
        private string[] nombres;
        private int[] tiempos;

        public void Cargar()
        {
            nombres = new string[5];
            tiempos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre atleta: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Tiempo (segundos): ");
                tiempos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int suma = 0;
            int mejor = tiempos[0];
            int peor = tiempos[0];
            string nombreMejor = nombres[0];
            string nombrePeor = nombres[0];

            for (int i = 0; i < 5; i++)
            {
                suma += tiempos[i];

                if (tiempos[i] < mejor)
                {
                    mejor = tiempos[i];
                    nombreMejor = nombres[i];
                }

                if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                    nombrePeor = nombres[i];
                }
            }

            double promedio = suma / 5.0;

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mejor tiempo: " + nombreMejor);
            Console.WriteLine("Peor tiempo: " + nombrePeor);

            Console.WriteLine("Superaron el promedio:");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.WriteLine(nombres[i]);
                }
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Procesar();
        }
    }
}