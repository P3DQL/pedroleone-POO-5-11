using System;

class Program
{
    static void Main()
    {
        /*2.Se ingresan seis notas de un alumno, 
         * si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
        */
        string linea;
        double n1, n2, n3, n4, n5, n6;

        Console.Write("Ingrese la nota 1: ");
        linea = Console.ReadLine();
        n1 = double.Parse(linea);

        Console.Write("Ingrese la nota 2: ");
        linea = Console.ReadLine();
        n2 = double.Parse(linea);

        Console.Write("Ingrese la nota 3: ");
        linea = Console.ReadLine();
        n3 = double.Parse(linea);

        Console.Write("Ingrese la nota 4: ");
        linea = Console.ReadLine();
        n4 = double.Parse(linea);

        Console.Write("Ingrese la nota 5: ");
        linea = Console.ReadLine();
        n5 = double.Parse(linea);

        Console.Write("Ingrese la nota 6: ");
        linea = Console.ReadLine();
        n6 = double.Parse(linea);

        double promedio = (n1 + n2 + n3 + n4 + n5 + n6) / 6;

        if (promedio >= 7)
        {
            Console.WriteLine("Promocionado");
        }

        Console.ReadKey();
    }
}