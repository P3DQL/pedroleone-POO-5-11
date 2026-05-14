using System;

namespace Ejercicio3
{
    class Program
    {
        /*3. Academia de Gastronomía: Recetario Dinámico
            Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
            una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
            ● Definir un vector para los nombres de los alumnos.
            ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
            presentado.
            ● Métodos:
            1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
            de cada alumno.
            2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
            3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
            4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
            (promedio &gt;= 70) o &quot;Reprobado&quot;.
            5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
            valor máximo de la matriz).
        */
        static string[] alumnos = new string[3];
        static int[][] puntajes = new int[3][];

        static void Cargar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre del alumno: ");
                alumnos[i] = Console.ReadLine();

                Console.Write("Cantidad de platos: ");
                int cant = int.Parse(Console.ReadLine());

                puntajes[i] = new int[cant];

                for (int j = 0; j < cant; j++)
                {
                    int nota;

                    do
                    {
                        Console.Write("Ingrese puntaje: ");
                        nota = int.Parse(Console.ReadLine());
                    }
                    while (nota < 0 || nota > 100);

                    puntajes[i][j] = nota;
                }
            }
        }

        static void Mostrar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + alumnos[i]);

                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.Write(puntajes[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Promedios()
        {
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;

                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    suma += puntajes[i][j];
                }

                int promedio = suma / puntajes[i].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine(alumnos[i] + ": Aprobado");
                }
                else
                {
                    Console.WriteLine(alumnos[i] + ": Reprobado");
                }
            }
        }

        static void MayorPuntaje()
        {
            int mayor = puntajes[0][0];
            string alumno = alumnos[0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    if (puntajes[i][j] > mayor)
                    {
                        mayor = puntajes[i][j];
                        alumno = alumnos[i];
                    }
                }
            }

            Console.WriteLine("Mayor puntaje: " + mayor);
            Console.WriteLine("Alumno: " + alumno);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Mostrar();
            p.Promedios();
            p.MayorPuntaje();

            Console.ReadKey();
        }
    }
}