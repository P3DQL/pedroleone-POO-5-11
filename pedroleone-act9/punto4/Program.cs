using System;

namespace Ejercicio4
{
    class Program
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)
        */
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Nombre docente: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int max = notas[0];
            int min = notas[0];
            string nombreMax = nombres[0];
            string nombreMin = nombres[0];

            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] > max)
                {
                    max = notas[i];
                    nombreMax = nombres[i];
                }

                if (notas[i] < min)
                {
                    min = notas[i];
                    nombreMin = nombres[i];
                }

                if (notas[i] >= 6)
                    aprobados++;
                else
                    desaprobados++;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        int auxNota = notas[i];
                        notas[i] = notas[j];
                        notas[j] = auxNota;

                        string auxNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNombre;
                    }
                }
            }

            Console.WriteLine("Mayor nota: " + nombreMax);
            Console.WriteLine("Menor nota: " + nombreMin);

            Console.WriteLine("Lista ordenada:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nombres[i] + " - " + notas[i]);
            }

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);

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