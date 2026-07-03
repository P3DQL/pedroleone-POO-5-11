using System;

class Vuelo
{
    public string codigo;
    public DateTime horaSalida;
    public DateTime horaLlegada;

    public Vuelo(
        string codigo,
        DateTime horaSalida,
        DateTime horaLlegada)
    {
        this.codigo =
            codigo;

        this.horaSalida =
            horaSalida;

        this.horaLlegada =
            horaLlegada;
    }

    public TimeSpan Duracion()
    {
        return horaLlegada -
               horaSalida;
    }
}

class Program
{
    static void Main()
    {
        Vuelo[] vuelos =
            new Vuelo[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write(
                "Código: ");

            string codigo =
                Console.ReadLine();

            Console.Write(
                "Hora salida: ");

            DateTime salida =
                DateTime.Parse(
                    Console.ReadLine());

            Console.Write(
                "Hora llegada: ");

            DateTime llegada =
                DateTime.Parse(
                    Console.ReadLine());

            vuelos[i] =
                new Vuelo(
                    codigo,
                    salida,
                    llegada);

            Console.WriteLine();
        }

        Vuelo mayor =
            vuelos[0];

        Vuelo temprano =
            vuelos[0];

        foreach (Vuelo v
                 in vuelos)
        {
            if (v.Duracion() >
                mayor.Duracion())
            {
                mayor = v;
            }

            if (v.horaSalida <
                temprano.horaSalida)
            {
                temprano = v;
            }
        }

        Console.WriteLine(
            "Vuelo más largo: " +
            mayor.codigo);

        Console.WriteLine(
            "Vuelo más temprano: " +
            temprano.codigo);
    }
}