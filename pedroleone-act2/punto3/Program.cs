using System;

class Program
{
    static void Main()
    {
        /*3.Se ingresa por teclado un número positivo de uno o dos dígitos(1..99) 
         * mostrar un mensaje indicando si el número tiene uno o dos dígitos.
         * (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
        */
        string linea;
        int num;

        Console.Write("Ingrese un número (1 a 99): ");
        linea = Console.ReadLine();
        num = int.Parse(linea);

        if (num >= 10 && num <= 99)
        {
            Console.WriteLine("Tiene dos dígitos");
        }
        else
        {
            Console.WriteLine("Tiene un dígito");
        }

        Console.ReadKey();
    }
}