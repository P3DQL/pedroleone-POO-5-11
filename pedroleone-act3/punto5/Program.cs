using System;

class Program
{
    static void Main()
    {
        /* 5. Escribir un programa que pida ingresar la coordenada de un punto en el plano,
        es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. 
        (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 
        */
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("1er Cuadrante");
        else if (x < 0 && y > 0)
            Console.WriteLine("2do Cuadrante");
        else if (x < 0 && y < 0)
            Console.WriteLine("3er Cuadrante");
        else
            Console.WriteLine("4to Cuadrante");
    }
}