using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se cuenta con la siguiente información:
                     Las edades de 20 estudiantes del turno mañana.
                     Las edades de 30 estudiantes del turno tarde.
                     Las edades de 15 estudiantes del turno noche.
              Las edades de cada estudiante deben ingresarse por teclado.
              a) Obtener el promedio de las edades de cada turno (tres promedios)
              b) Imprimir dichos promedios (promedio de cada turno)
              c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
              promedio de edades menor.
             */
            int edad, acumañana, acutarde, acunoche, promañana, protarde, pronoche, alumañana, alutarde, alunoche;
            string linea;
            alumañana = 20;
            alutarde = 30;
            alunoche = 15;
            acumañana = 0;
            acutarde = 0;
            acunoche = 0;

            for (int i = 1; i <= alumañana; i++)
            {
                Console.Write("ingrese edad del alumno numero " + i + ": ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                acumañana = edad + acumañana;
            }

            promañana = acumañana / 20;
            Console.WriteLine("el promedio de edad del turno mañana es: " + promañana);

            for (int i = 1; i <= alutarde; i++)
            {
                Console.Write("ingrese edad del alumno numero " + i + ": ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                acutarde = edad + acutarde;
            }

            protarde = acutarde / 30;
            Console.WriteLine("el promedio de edad del turno tarde es: " + protarde);

            for (int i = 1; i <= alumañana; i++)
            {
                Console.Write("ingrese edad del alumno numero " + i + ": ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                acunoche = edad + acunoche;
            }

            pronoche = acunoche / 15;
            Console.WriteLine("el promedio de edad del turno noche es: " + pronoche);
            Console.ReadKey();
        }
    }
}
