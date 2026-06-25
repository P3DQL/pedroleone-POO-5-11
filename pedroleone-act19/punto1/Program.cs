using System;
/*1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
 */
public partial class ReservaHotel
{
    private string nombreCliente;
    private int cantidadNoches;
    private string tipoHabitacion;

    public string NombreCliente
    {
        get { return nombreCliente; }
        set { nombreCliente = value; }
    }

    public int CantidadNoches
    {
        get { return cantidadNoches; }
        set
        {
            if (value > 0)
                cantidadNoches = value;
        }
    }

    public string TipoHabitacion
    {
        get { return tipoHabitacion; }
        set { tipoHabitacion = value; }
    }
}

public partial class ReservaHotel
{
    public double CalcularTotal()
    {
        double precio = 0;

        if (TipoHabitacion == "Simple")
            precio = 5000;

        else if (TipoHabitacion == "Doble")
            precio = 8000;

        else if (TipoHabitacion == "Suite")
            precio = 12000;

        return precio * CantidadNoches;
    }
}

class Program
{
    static void Main()
    {
        ReservaHotel[] reservas = new ReservaHotel[3];

        for (int i = 0; i < 3; i++)
        {
            reservas[i] = new ReservaHotel();

            Console.WriteLine("RESERVA " + (i + 1));

            Console.Write("Cliente: ");
            reservas[i].NombreCliente = Console.ReadLine();

            Console.Write("Cantidad de noches: ");
            reservas[i].CantidadNoches =
                int.Parse(Console.ReadLine());

            Console.Write("Tipo habitación: ");
            reservas[i].TipoHabitacion =
                Console.ReadLine();

            Console.WriteLine();
        }

        ReservaHotel mayor = reservas[0];

        foreach (ReservaHotel r in reservas)
        {
            if (r.CalcularTotal() > mayor.CalcularTotal())
                mayor = r;
        }

        Console.WriteLine("Cliente que más pagará:");
        Console.WriteLine(mayor.NombreCliente);
        Console.WriteLine("Total: $" + mayor.CalcularTotal());
    }
}