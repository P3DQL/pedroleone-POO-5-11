using System;

class Program
{
    static void Main()
    {
        // 3.Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a < 10 && b < 10 && c < 10)
            Console.WriteLine("Todos los números son menores a diez");
    }
}
