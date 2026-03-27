using System;

class Program
{
    static void Main()
    {
        /*4. Se cargan por teclado tres números distintos. 
         * Mostrar por pantalla el mayor de ellos.
         */
        string linea;
        int num1, num2, num3;

        Console.Write("Ingrese el primer número: ");
        linea = Console.ReadLine();
        num1 = int.Parse(linea);

        Console.Write("Ingrese el segundo número: ");
        linea = Console.ReadLine();
        num2 = int.Parse(linea);

        Console.Write("Ingrese el tercer número: ");
        linea = Console.ReadLine();
        num3 = int.Parse(linea);

        int mayor = num1;

        if (num2 > mayor)
        {
            mayor = num2;
        }

        if (num3 > mayor)
        {
            mayor = num3;
        }

        Console.WriteLine("El mayor es: " + mayor);

        Console.ReadKey();
    }
}