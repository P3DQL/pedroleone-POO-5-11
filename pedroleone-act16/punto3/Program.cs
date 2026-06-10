using System;
/*3. Crear una clase base Vehículo que contenga atributos marca y
velocidadMaxima.
Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
una debe tener un constructor que reciba los valores de los atributos base
mediante la palabra clave base, y un atributo propio (cantidadPuertas en
Auto, cilindrada en Moto).
Crear un objeto de cada clase y mostrar todos sus datos por consola.
*/
class Vehiculo
{
    public string Marca { get; set; }
    public int VelocidadMaxima { get; set; }

    public Vehiculo(string marca, int velocidadMaxima)
    {
        Marca = marca;
        VelocidadMaxima = velocidadMaxima;
    }
}

class Auto : Vehiculo
{
    public int CantidadPuertas { get; set; }

    public Auto(string marca, int velocidadMaxima, int cantidadPuertas)
        : base(marca, velocidadMaxima)
    {
        CantidadPuertas = cantidadPuertas;
    }

    public void Mostrar()
    {
        Console.WriteLine("AUTO");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Velocidad Máxima: " + VelocidadMaxima);
        Console.WriteLine("Puertas: " + CantidadPuertas);
    }
}

class Moto : Vehiculo
{
    public int Cilindrada { get; set; }

    public Moto(string marca, int velocidadMaxima, int cilindrada)
        : base(marca, velocidadMaxima)
    {
        Cilindrada = cilindrada;
    }

    public void Mostrar()
    {
        Console.WriteLine("MOTO");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Velocidad Máxima: " + VelocidadMaxima);
        Console.WriteLine("Cilindrada: " + Cilindrada + "cc");
    }
}

class Program
{
    static void Main()
    {
        Auto auto = new Auto("Toyota", 220, 4);
        Moto moto = new Moto("Honda", 180, 250);

        auto.Mostrar();

        Console.WriteLine();

        moto.Mostrar();
    }
}