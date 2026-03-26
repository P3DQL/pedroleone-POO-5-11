using System;

class Program
{
    static void Main()
    {
        /* Se ingresan seis notas de un alumno,
         si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
        */
        double suma = 0;

        for (int i = 0; i < 6; i++)
        {
            suma += Convert.ToDouble(Console.ReadLine());
        }

        double promedio = suma / 6;

        if (promedio >= 7)
        {
            Console.WriteLine("Promocionado");
        }
    }
}