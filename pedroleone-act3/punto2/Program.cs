using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        // 2.Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine((a + b) * c);
    }
}