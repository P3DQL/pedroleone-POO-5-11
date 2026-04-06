using System;

class Program
{
    static void Main()
    {
        /*
         * 5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
         * es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en 
         * pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 ,
         * 2º Cuadrante: x < 0 Y y > 0). 
         */
        string linea;
        int x, y;

        Console.Write("Ingrese el valor de X: ");
        linea = Console.ReadLine();
        x = int.Parse(linea);

        Console.Write("Ingrese el valor de Y: ");
        linea = Console.ReadLine();
        y = int.Parse(linea);

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Primer cuadrante");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Segundo cuadrante");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Tercer cuadrante");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Cuarto cuadrante");
        }

        Console.ReadKey();
    }
}