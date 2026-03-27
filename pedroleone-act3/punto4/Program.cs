using System;

class Program
{
    static void Main()
    {
        /*4. Se ingresan por teclado tres números, 
         * si al menos uno de los valores ingresados es menor a 10, 
         * imprimir en pantalla la leyenda "Alguno de los números es menor a diez"
         */
        string linea;
        int n1, n2, n3;

        Console.Write("Ingrese el primer número: ");
        linea = Console.ReadLine();
        n1 = int.Parse(linea);

        Console.Write("Ingrese el segundo número: ");
        linea = Console.ReadLine();
        n2 = int.Parse(linea);

        Console.Write("Ingrese el tercer número: ");
        linea = Console.ReadLine();
        n3 = int.Parse(linea);

        if (n1 < 10 || n2 < 10 || n3 < 10)
        {
            Console.WriteLine("Alguno de los números es menor a diez");
        }

        Console.ReadKey();
    }
}