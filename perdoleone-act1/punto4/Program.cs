using System;

class Punto4
{
    static void Main(string[] args)
    {
        /* 4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y 
         * la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
        */
        Console.Write("Ingrese el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double total = precio * cantidad;

        Console.WriteLine("Total a pagar: " + total); 
        Console.ReadKey();
    }
}