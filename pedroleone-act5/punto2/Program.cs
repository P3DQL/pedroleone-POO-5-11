using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
              a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
              iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
              b) Cantidad de triángulos de cada tipo.
              c) Tipo de triángulo que posee menor cantidad.
             */
            int lado1, lado2, lado3, canttri, cantequi, cantiso, cantesca;
            string linea;
            cantequi = 0;
            cantiso = 0;
            cantesca = 0;
            Console.Write("ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            canttri = int.Parse(linea);
            for (int i = 0; i < canttri; i++)
            {
                Console.Write("ingrese el lado 1: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.Write("ingrese el lado 2: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.Write("ingrese el lado 3: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("el triangulo es equilatero ");
                    cantequi++;
                }
                else
                {
                    if (lado1 == lado2 || lado2 == lado3)
                    {
                        Console.WriteLine("el triangulo es isoceles ");
                        cantiso++;
                    }
                    else
                    {
                        Console.WriteLine("el triangulo es escaleno ");
                        cantesca++;
                    }
                }

            }
            Console.WriteLine("la cantidad de triangulos equilateros es: " + cantequi);
            Console.WriteLine("la cantidad de triangulos isoceles es: " + cantiso);
            Console.WriteLine("la cantidad de triangulos escalenos es: " + cantesca);
            if (cantequi < cantiso && cantequi < cantesca) {
                Console.Write("el triangulo equilatero es el que menor cantidad tiene");
            }
            else 
            {
                if (cantiso < cantequi && cantiso < cantesca)
                {
                    Console.Write("el triangulo isoceles es el que menor cantidad tiene");
                }
                else
                {
                    Console.Write("el triangulo escaleno es el que menor cantidad tiene");
                }
            }
            Console.ReadKey();
        }
    }
}
