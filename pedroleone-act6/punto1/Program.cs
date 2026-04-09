using System;

class Punto
{
    /*1. Desarrollar una clase que represente un punto en el plano y tenga los
        siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
        positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
    */
    private int x, y;

    public void Cargar()
    {
        Console.Write("Ingrese valor de X: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese valor de Y: ");
        y = int.Parse(Console.ReadLine());
    }

    public void Cuadrante()
    {
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
    }
}

class Program
{
    static void Main()
    {
        Punto p = new Punto();
        p.Cargar();
        p.Cuadrante();

        Console.ReadKey();
    }
}
