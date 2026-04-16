using System;

class Program
{
    /*  2. Desarrollar una clase que represente un cuadrado y tenga los siguientes
        métodos: cargar el valor del lado, imprimir el perímetro y la superficie del
        cuadrado.
    */
    private int lado;

    public void Cargar()
    {
        Console.Write("Ingrese el valor del lado: ");
        lado = int.Parse(Console.ReadLine());
    }

    public void Perimetro()
    {
        int perimetro = lado * 4;
        Console.WriteLine("Perímetro: " + perimetro);
    }

    public void Superficie()
    {
        int superficie = lado * lado;
        Console.WriteLine("Superficie: " + superficie);
    }

    static void Main()
    {
        Program p = new Program();
        p.Cargar();
        p.Perimetro();
        p.Superficie();

        Console.ReadKey();
    }
}