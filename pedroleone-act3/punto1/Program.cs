using System;

class Program
{
    static void Main()
    {
        //1.Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
        int dia = Convert.ToInt32(Console.ReadLine());
        int mes = Convert.ToInt32(Console.ReadLine());

        if (dia == 25 && mes == 12)
            Console.WriteLine("Es Navidad");
        else
            Console.WriteLine("No es Navidad");
    }
}