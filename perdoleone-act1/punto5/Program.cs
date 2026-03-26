using System;
using System.Security.Cryptography;

class Punto5
{
    static void Main(string[] args)
    {
        /*  5.Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y
         *  el área del mismo(La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
        */
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double circunferencia = 2 * Math.PI * radio;
        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("Circunferencia: " + circunferencia);
        Console.WriteLine("Área: " + area);
    }
}