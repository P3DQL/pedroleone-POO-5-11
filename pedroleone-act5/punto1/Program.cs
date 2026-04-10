using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            39.
            */
            int num, valor, multiplo;
            string linea;
            multiplo = 0;
            Console.Write("ingrese un valor del 1 al 10: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            if (valor >= 0 && valor <= 10)
            {
                for (num = 1; num<= 13; num++)
                {
                    multiplo = num * valor;
                    Console.WriteLine(multiplo);
                }
            }
            Console.ReadKey();
        }
    }
}
