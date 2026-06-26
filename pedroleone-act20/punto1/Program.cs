using System;
/*Actividad 1: Sistema de control de vuelos
Problema:
Una aerolínea administra los vuelos programados mediante un sistema orientado a
objetos.
Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
destino y duración en horas. Luego definir una clase derivada VueloInternacional que
herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
desde consola y luego:
 Mostrar los vuelos registrados y el país de destino.
 Informar cuál es el vuelo con mayor duración.
 Mostrar el orden de ejecución de los constructores.
*/
class Vuelo
{
    private string numeroVuelo;
    private string destino;
    private double duracionHoras;

    public string NumeroVuelo
    {
        get { return numeroVuelo; }
        set { numeroVuelo = value; }
    }

    public string Destino
    {
        get { return destino; }
        set { destino = value; }
    }

    public double DuracionHoras
    {
        get { return duracionHoras; }
        set
        {
            if (value > 0)
                duracionHoras = value;
        }
    }

    public Vuelo()
    {
        Console.WriteLine(
            "Constructor de Vuelo");
    }

    public void Mostrar()
    {
        Console.WriteLine(
            "Vuelo: " + numeroVuelo);
        Console.WriteLine(
            "Destino: " + destino);
        Console.WriteLine(
            "Duración: " +
            duracionHoras + " hs");
    }
}

class VueloInternacional : Vuelo
{
    private string paisDestino;

    public string PaisDestino
    {
        get { return paisDestino; }
        set { paisDestino = value; }
    }

    public VueloInternacional()
    {
        Console.WriteLine(
            "Constructor de VueloInternacional");
    }

    public void MostrarVuelo()
    {
        Mostrar();

        Console.WriteLine(
            "País destino: " +
            paisDestino);
    }
}

class Program
{
    static void Main()
    {
        VueloInternacional[] vuelos =
            new VueloInternacional[5];

        for (int i = 0; i < 5; i++)
        {
            vuelos[i] =
                new VueloInternacional();

            Console.WriteLine(
                "VUELO " + (i + 1));

            Console.Write(
                "Número de vuelo: ");
            vuelos[i].NumeroVuelo =
                Console.ReadLine();

            Console.Write(
                "Destino: ");
            vuelos[i].Destino =
                Console.ReadLine();

            Console.Write(
                "Duración: ");
            vuelos[i].DuracionHoras =
                double.Parse(
                    Console.ReadLine());

            Console.Write(
                "País destino: ");
            vuelos[i].PaisDestino =
                Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine(
            "VUELOS REGISTRADOS");

        foreach (VueloInternacional v
                 in vuelos)
        {
            v.MostrarVuelo();

            Console.WriteLine();
        }

        VueloInternacional mayor =
            vuelos[0];

        foreach (VueloInternacional v
                 in vuelos)
        {
            if (v.DuracionHoras >
                mayor.DuracionHoras)
            {
                mayor = v;
            }
        }

        Console.WriteLine(
            "VUELO CON MAYOR DURACIÓN");

        mayor.MostrarVuelo();
    }
}
