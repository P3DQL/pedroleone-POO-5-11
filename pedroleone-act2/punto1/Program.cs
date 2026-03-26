using System;
class Program
{
    static void Main()
    {
        /*1. Realizar un programa que lea por teclado dos números, 
         * si el primero es mayor al segundo informar su suma y diferencia, 
         * en caso contrario informar el producto y la división del primero respecto al segundo.
        */
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
        }
        else
        {
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}