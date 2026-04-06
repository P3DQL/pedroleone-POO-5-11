using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = int.Parse(Console.ReadLine());

        // Verificamos si los tres números son iguales
        if (num1 == num2 && num2 == num3)
        {
            int suma = num1 + num2;
            int resultado = suma * num3;

            Console.WriteLine("La suma del primero y segundo es: " + suma);
            Console.WriteLine("El resultado de (suma * tercero) es: " + resultado);
        }
        else
        {
            Console.WriteLine("Los números no son iguales.");
        } 
        Console.ReadKey();
    }
}