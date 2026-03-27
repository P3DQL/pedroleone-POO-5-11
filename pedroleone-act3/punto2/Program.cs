using System;

class Program
{
    static void Main()
    {
        /*2. Se ingresan tres valores por teclado, 
         * si todos son iguales se imprime la suma del primero con el segundo y 
         * a este resultado se lo multiplica por el tercero.
         */
        string linea;
        int a, b, c;

        Console.Write("Ingrese el primer valor: ");
        linea = Console.ReadLine();
        a = int.Parse(linea);

        Console.Write("Ingrese el segundo valor: ");
        linea = Console.ReadLine();
        b = int.Parse(linea);

        Console.Write("Ingrese el tercer valor: ");
        linea = Console.ReadLine();
        c = int.Parse(linea);

        if (a == b && b == c)
        {
            int resultado = (a + b) * c;
            Console.WriteLine("Resultado: " + resultado);
        }

        Console.ReadKey();
    }
}