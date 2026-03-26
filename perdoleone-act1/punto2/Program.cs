using System;

class Punto2
{
    static void Main(string[] args)
    {
        /* 2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar 
         * la suma de los dos primeros y el producto del tercero y el cuarto.
        */
        Console.Write("Ingrese el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        double suma = n1 + n2;
        double producto = n3 * n4;

        Console.WriteLine("Suma de los dos primeros: " + suma);
        Console.WriteLine("Producto del tercero y cuarto: " + producto);
        Console.ReadKey();
    }
}
