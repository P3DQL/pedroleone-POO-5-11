using System;

class Punto6
{
    static void Main(string[] args)
    {
        /* 6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) 
         * de una persona, y mostrar por pantalla su índice de masa corporal (IMC) 
         * (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).
        */
        Console.Write("Ingrese su peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);

        Console.WriteLine("Su IMC es: " + imc);
        Console.ReadKey();
    }
}