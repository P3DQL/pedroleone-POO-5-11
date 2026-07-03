using System;
class Corredor
{
    public string nombre;
    public int dorsal;
    public int tiempo;

    public void RegistrarTiempo(
        int minutos)
    {
        tiempo = minutos;
    }

    public void RegistrarTiempo(
        int horas,
        int minutos)
    {
        tiempo =
            (horas * 60) +
            minutos;
    }
}

class Carrera
{
    public string codigo;
    public DateTime inicio;
    public DateTime fin;

    public Carrera()
    {
        codigo = "A1";

        inicio =
            DateTime.Parse("08:00");

        fin =
            DateTime.Parse("10:00");
    }

    public Carrera(
        string codigo,
        DateTime inicio,
        DateTime fin)
    {
        this.codigo = codigo;
        this.inicio = inicio;
        this.fin = fin;
    }

    public TimeSpan Duracion()
    {
        return fin - inicio;
    }
}

class Program
{
    static void Main()
    {
        Carrera[] carreras =
        {
            new Carrera(
                "C1",
                DateTime.Parse("08:00"),
                DateTime.Parse("11:00")),

            new Carrera(
                "C2",
                DateTime.Parse("09:00"),
                DateTime.Parse("10:00"))
        };

        Corredor[] corredores =
            new Corredor[3];

        for (int i = 0; i < 3; i++)
        {
            corredores[i] =
                new Corredor();

            Console.Write(
                "Nombre: ");

            corredores[i].nombre =
                Console.ReadLine();

            Console.Write(
                "Minutos: ");

            int minutos =
                int.Parse(
                    Console.ReadLine());

            corredores[i]
                .RegistrarTiempo(
                    minutos);

            Console.WriteLine();
        }

        Carrera mayor =
            carreras[0];

        foreach (Carrera c
                 in carreras)
        {
            if (c.Duracion() >
                mayor.Duracion())
            {
                mayor = c;
            }
        }

        Corredor rapido =
            corredores[0];

        foreach (Corredor c
                 in corredores)
        {
            if (c.tiempo <
                rapido.tiempo)
            {
                rapido = c;
            }
        }

        Console.Clear();

        Console.SetCursorPosition(
            5, 5);

        Console.Write(
            "Carrera más larga: " +
            mayor.codigo);

        Console.SetCursorPosition(
            5, 7);

        Console.Write(
            "Más rápido: " +
            rapido.nombre);

        Console.ReadKey();
    }
}