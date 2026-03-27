using System;

class Program
{
    static void Main()
    {
        ;       /*1. Realizar un programa que lea por teclado dos números, 
                 * si el primero es mayor al segundo informar su suma y diferencia, 
                 * en caso contrario informar el producto y la división del 
                 * primero respecto al segundo.
                 */
        int num1, num2;
        string linea;

        Console.Write("Ingrese el primer número: ");
        linea = Console.ReadLine();
        num1 = int.Parse(linea);

        Console.Write("Ingrese el segundo número: ");
        linea = Console.ReadLine();
        num2 = int.Parse(linea);

        if (num1 > num2)
        {
            int suma = num1 + num2;
            int diferencia = num1 - num2;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Diferencia: " + diferencia);
        }
        else
        {
            int producto = num1 * num2;
            double division = (double)num1 / num2;
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("División: " + division);
        }

        Console.ReadKey();
    }
}