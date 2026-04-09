using System;

class Cuadrado
{
    /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
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
}

class Program
{
    static void Main()
    {
        Cuadrado c = new Cuadrado();
        c.Cargar();
        c.Perimetro();
        c.Superficie();

        Console.ReadKey();
    }
}
