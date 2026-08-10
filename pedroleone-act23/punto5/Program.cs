using System;
using System.Collections.Generic;
/*5-
Un taller mecánico automatizado administra la recepción y egreso de automóviles
que se encuentran en el sector de reparaciones.
 Crear la clase Vehiculo que contenga como atributos privados: patente
(string) y costoReparacion (double). Definir sus propiedades
correspondientes y un constructor que reciba pat y costo.
 Crear la clase GestionTaller que administre una lista de objetos List.
 Métodos en GestionTaller:
o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
reparación de un vehículo para agregarlo a la lista mediante .Add().
o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
recorriendo la lista, informar si el vehículo está en el taller y mostrar
su costo asociado.
o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
vehículo en la lista y, si existe, removerlo de la colección mediante
.Remove() confirmando la entrega del automóvil.

o CalcularRecaudacionPendiente(): Listar los vehículos
actualmente en reparación, la cantidad total de unidades alojadas en
el taller mediante la propiedad .Count y la suma total acumulada por
cobrar.
 */
class Vehiculo
{
    private string patente;
    private double costoReparacion;

public string Patente
    {
        get { return patente; }
        set { patente = value; }
    }

    public double CostoReparacion
    {
        get { return costoReparacion; }
        set { costoReparacion = value; }
    }

    public Vehiculo(
        string pat,
        double costo)
    {
        patente = pat;
        costoReparacion = costo;
    }

}

class GestionTaller
{
    private List<Vehiculo> vehiculos =
    new List<Vehiculo>();

public void IngresarVehiculo()
    {
        Console.Write(
            "Patente: ");

        string pat =
            Console.ReadLine();

        Console.Write(
            "Costo reparación: ");

        double costo =
            double.Parse(
                Console.ReadLine());

        vehiculos.Add(
            new Vehiculo(
                pat,
                costo));
    }

    public void BuscarVehiculo()
    {
        Console.Write(
            "Buscar patente: ");

        string pat =
            Console.ReadLine();

        foreach (Vehiculo v
                 in vehiculos)
        {
            if (v.Patente == pat)
            {
                Console.WriteLine(
                    "Costo: $" +
                    v.CostoReparacion);

                return;
            }
        }

        Console.WriteLine(
            "Vehículo no encontrado");
    }

    public void EntregarVehiculo()
    {
        Console.Write(
            "Patente a entregar: ");

        string pat =
            Console.ReadLine();

        for (int i = 0;
             i < vehiculos.Count;
             i++)
        {
            if (vehiculos[i].Patente
                == pat)
            {
                vehiculos.RemoveAt(i);

                Console.WriteLine(
                    "Vehículo entregado");

                return;
            }
        }

        Console.WriteLine(
            "Vehículo no encontrado");
    }

    public void CalcularRecaudacionPendiente()
    {
        double total = 0;

        foreach (Vehiculo v
                 in vehiculos)
        {
            Console.WriteLine(
                v.Patente +
                " - $" +
                v.CostoReparacion);

            total +=
                v.CostoReparacion;
        }

        Console.WriteLine(
            "Cantidad: " +
            vehiculos.Count);

        Console.WriteLine(
            "Total a cobrar: $" +
            total);
    }

}

class Program
{
    static void Main()
    {
        GestionTaller g =
        new GestionTaller();

    for (int i = 0; i < 3; i++)
        {
            g.IngresarVehiculo();
        }

        Console.WriteLine();

        g.BuscarVehiculo();

        Console.WriteLine();

        g.EntregarVehiculo();

        Console.WriteLine();

        g.CalcularRecaudacionPendiente();
    }

}
