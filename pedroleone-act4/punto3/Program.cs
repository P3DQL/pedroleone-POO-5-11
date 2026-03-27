using System;

class Program
{
    static void Main()
    {
        /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
          ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
          valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
         */
        int suma = 0;
        int num;

        do
        {
            Console.Write("Ingrese número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 9999)
                suma += num;

        } while (num != 9999);

        string estado;

        if (suma > 0)
            estado = "Mayor a cero";
        else if (suma < 0)
            estado = "Menor a cero";
        else
            estado = "Es cero";

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Resultado: " + estado);

        Console.ReadKey();
    }
}