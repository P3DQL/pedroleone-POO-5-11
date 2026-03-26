using System;

class Program
{
    static void Main()
    {
        // 4. Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
            Console.WriteLine(a);
        else if (b > c)
            Console.WriteLine(b);
        else
            Console.WriteLine(c);
    }
}
