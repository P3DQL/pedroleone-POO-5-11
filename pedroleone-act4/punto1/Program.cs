using System;

class Program
{
    static void Main()
    {
        /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
          $500, realizar un programa que lea los sueldos que cobra cada empleado e
          informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
          de $300. Además el programa deberá informar el importe que gasta la empresa
          en sueldos al personal.
         */
        Console.Write("Cantidad de empleados: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        int entre100y300 = 0;
        int mas300 = 0;
        double total = 0;

        while (i <= n)
        {
            Console.Write("Ingrese sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            if (sueldo >= 100 && sueldo <= 300)
                entre100y300++;
            else if (sueldo > 300)
                mas300++;

            total += sueldo;
            i++;
        }

        string resultado = "Entre 100 y 300: " + entre100y300 +
                           "\nMás de 300: " + mas300 +
                           "\nTotal sueldos: " + total;

        Console.WriteLine(resultado);

        Console.ReadKey();
    }
}