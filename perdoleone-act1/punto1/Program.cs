using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Punto1
{
    static void Main(string[] args)
    {
        /* 1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo 
         * (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
        */
        Console.Write("Ingrese el valor del lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        double perimetro = lado * 4;

        Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
        Console.ReadKey();
    }
}
