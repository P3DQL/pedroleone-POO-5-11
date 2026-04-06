using System;

class Program
{
    static void Main()
    {
        /*3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, 
         * imprimir en pantalla la leyenda "Todos los números son menores a diez"
         */
        string linea;
        int n1, n2, n3;

        Console.Write("Ingrese el primer número: ");
        linea = Console.ReadLine();
        n1 = int.Parse(linea);

        Console.Write("Ingrese el segundo número: ");
        input = Console.ReadLine();
        n2 = int.Parse(input);

        Console.Write("Ingrese el tercer número: ");
        linea = Console.ReadLine();
        n3 = int.Parse(linea);

        if (n1 < 10 && n2 < 10 && n3 < 10)
        {
            Console.WriteLine("Todos los números son menores a diez");
        }

        Console.ReadKey();
    }
}