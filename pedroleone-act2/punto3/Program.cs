using System;

class Program
{
    static void Main()
    {
        /*Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) 
         * mostrar un mensaje indicando si el número tiene uno o dos dígitos.
         * (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
         */
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 10)
        {
            Console.WriteLine("Tiene un dígito");
        }
        else
        {
            Console.WriteLine("Tiene dos dígitos");
        }
    }
}