using System;
using System.Collections.Generic;
/*10-
Un estacionamiento medido administra el ingreso y la salida de los vehículos que
utilizan su playa por orden de llegada.
 Crear la clase Ticket que contenga como atributos privados: patente
(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
constructor que reciba pat y hs.
 Crear la clase GestionEstacionamiento que administre una lista
dinámica de tickets (List).
 Métodos en GestionEstacionamiento:
o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
agregarlo al final de la lista utilizando .Add().
o ProcesarSalida(): Si la lista no está vacía, simular la salida del
primer vehículo de la lista (mostrar sus datos en consola) y
removerlo de la colección mediante .RemoveAt(0). Si está vacía,
advertir que no hay vehículos esperando salida.
o MostrarVehiculosEstacionados(): Listar todos los vehículos
alojados en la playa y la cantidad total de unidades presentes
utilizando la propiedad .Count.
*/
class Ticket
{
    private string patente;
    private int horasEstadia;

    public string Patente
    {
        get { return patente; }
    }

    public int HorasEstadia
    {
        get { return horasEstadia; }
    }

    public Ticket(
        string pat,
        int hs)
    {
        patente = pat;
        horasEstadia = hs;
    }
}

class GestionEstacionamiento
{
    private List<Ticket> tickets =
        new List<Ticket>();

    public void RegistrarIngreso()
    {
        Console.Write("Patente: ");
        string patente =
            Console.ReadLine();

        Console.Write("Horas de estadía: ");
        int horas =
            int.Parse(Console.ReadLine());

        Ticket t =
            new Ticket(
                patente,
                horas);

        tickets.Add(t);
    }

    public void ProcesarSalida()
    {
        if (tickets.Count > 0)
        {
            Ticket t = tickets[0];

            Console.WriteLine(
                "Vehículo que sale:");

            Console.WriteLine(
                "Patente: " +
                t.Patente);

            Console.WriteLine(
                "Horas: " +
                t.HorasEstadia);

            tickets.RemoveAt(0);
        }
        else
        {
            Console.WriteLine(
                "No hay vehículos esperando salida.");
        }
    }

    public void MostrarVehiculosEstacionados()
    {
        Console.WriteLine(
            "VEHÍCULOS ESTACIONADOS");

        foreach (Ticket t in tickets)
        {
            Console.WriteLine(
                "Patente: " +
                t.Patente +
                " - Horas: " +
                t.HorasEstadia);
        }

        Console.WriteLine(
            "Cantidad de vehículos: " +
            tickets.Count);
    }
}

class Program
{
    static void Main()
    {
        GestionEstacionamiento g =
            new GestionEstacionamiento();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(
                "INGRESO " + (i + 1));

            g.RegistrarIngreso();

            Console.WriteLine();
        }

        g.MostrarVehiculosEstacionados();

        Console.WriteLine();

        g.ProcesarSalida();

        Console.WriteLine();

        g.MostrarVehiculosEstacionados();
    }
}