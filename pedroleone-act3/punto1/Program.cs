using System;

class Program
{
    static void Main()
    {
       /* 1.Realizar un programa que pida cargar una fecha cualquiera, 
        * luego verificar si dicha fecha corresponde a Navidad.
       */
        string linea;
        int dia, mes;

        Console.Write("Ingrese el día: ");
        linea = Console.ReadLine();
        dia = int.Parse(linea);

        Console.Write("Ingrese el mes: ");
        linea = Console.ReadLine();
        mes = int.Parse(linea);

        if (dia == 25 && mes == 12)
        {
            Console.WriteLine("Es Navidad");
        }
        else
        {
            Console.WriteLine("No es Navidad");
        }

        Console.ReadKey();
    }
}