using System;

namespace punto4
{
    /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.
        Agregar los siguientes métodos:
            a) Un método que imprima el nombre de cada alumno y su promedio.
            b) Un método que muestre el nombre del alumno con el promedio más
            alto.
            c) Un método que indique qué alumnos tienen al menos una nota
            desaprobada (nota menor a 6)
    */
    class Alumno
    {
        private string nombre;
        private int[] notas;

        public Alumno()
        {
            notas = new int[4];

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public int Promedio()
        {
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma += notas[i];
            }

            return suma / 4;
        }

        public string RetornarNombre()
        {
            return nombre;
        }
    }

    class Curso
    {
        private Alumno[] alumnos;

        public Curso()
        {
            alumnos = new Alumno[3];

            for (int i = 0; i < 3; i++)
            {
                alumnos[i] = new Alumno();
            }
        }

        public void MostrarPromedios()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(alumnos[i].RetornarNombre() + ": " + alumnos[i].Promedio());
            }
        }

        public void MejorPromedio()
        {
            Alumno mejor = alumnos[0];

            for (int i = 1; i < 3; i++)
            {
                if (alumnos[i].Promedio() > mejor.Promedio())
                {
                    mejor = alumnos[i];
                }
            }

            Console.WriteLine("Mejor promedio: " + mejor.RetornarNombre());
        }

        public void Aprobados()
        {
            Console.WriteLine("Alumnos aprobados:");

            for (int i = 0; i < 3; i++)
            {
                if (alumnos[i].Promedio() >= 7)
                {
                    Console.WriteLine(alumnos[i].RetornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            Curso c = new Curso();

            c.MostrarPromedios();
            c.MejorPromedio();
            c.Aprobados();

            Console.ReadKey();
        }
    }
}