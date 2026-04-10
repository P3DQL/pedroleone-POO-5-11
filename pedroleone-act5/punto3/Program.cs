using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
                a) La cantidad de valores ingresados negativos.
                b) La cantidad de valores ingresados positivos.
                c) La cantidad de múltiplos de 15.
                d) El valor acumulado de los números ingresados que son pares.
             */
            int num, cantposi, cantnega, cantmulti15, sumapar;
            string linea;
            cantposi = 0;
            cantnega = 0;
            cantmulti15 = 0;
            sumapar = 0;

            for (int i = 1; i <=10; i++)
            {
                Console.Write("ingrese un numero: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (num >0)
                {
                    cantposi++;
                }
                else
                {
                    cantnega++;
                }
                if (num % 15 == 0)
                {
                    cantmulti15++;
                }
                if (num % 2 == 0)
                {
                    sumapar = num + sumapar ;
                }
            }
            Console.WriteLine("la cantidad de numeros positivos es: " + cantposi);
            Console.WriteLine("la cantidad de numeros negativos es: " + cantnega);
            Console.WriteLine("la cantidad de numeros multiplos de 15  es: " + cantmulti15);
            Console.WriteLine("el valor acumulado de los numeros pares es: " + sumapar);
            Console.ReadKey();
        }
    }
}
