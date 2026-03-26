using System;

class Punto3
{
    static void Main(string[] args)
    {
        // 3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

        double suma = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Ingrese número " + i + ": ");
            suma += Convert.ToDouble(Console.ReadLine());
        }

        double promedio = suma / 4;

        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
        Console.ReadKey();
    }
}
