using System;

namespace Ejercicio1
{
    class Program
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.
        */
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int max = notas[0];
            int min = notas[0];
            string nombreMax = nombres[0];
            string nombreMin = nombres[0];

            bool repetidoMax = false;
            bool repetidoMin = false;

            for (int i = 1; i < 6; i++)
            {
                if (notas[i] > max)
                {
                    max = notas[i];
                    nombreMax = nombres[i];
                    repetidoMax = false;
                }
                else if (notas[i] == max)
                {
                    repetidoMax = true;
                }

                if (notas[i] < min)
                {
                    min = notas[i];
                    nombreMin = nombres[i];
                    repetidoMin = false;
                }
                else if (notas[i] == min)
                {
                    repetidoMin = true;
                }
            }

            Console.WriteLine("Mayor nota: " + nombreMax + " - " + max);
            Console.WriteLine("Menor nota: " + nombreMin + " - " + min);

            if (repetidoMax)
                Console.WriteLine("Hay más de un estudiante con la nota máxima");

            if (repetidoMin)
                Console.WriteLine("Hay más de un estudiante con la nota mínima");

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