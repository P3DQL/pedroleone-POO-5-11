using System;

class Program
{
    static void Main()
    {
        // 4. Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10, imprimir en pantalla la leyenda "Alguno de los números es menor a diez".
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a < 10 || b < 10 || c < 10)
            Console.WriteLine("Alguno de los números es menor a diez");
    }
}