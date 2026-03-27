using System;

class Program
{
    static void Main()
    {
        /* 2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
           (No se ingresan valores por teclado) 
        */
        int i = 1;

        while (i <= 25)
        {
            string texto = "Número: " + (i * 11);
            Console.WriteLine(texto);
            i++;
        }

        Console.ReadKey();
    }
}