using System;
using System.Collections.Generic;
/*7-
Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.
 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.
 Crear la clase GestionComandas que administre una lista de objetos List.
 Métodos en GestionComandas:
o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().
o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.
o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.
o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda.
*/
class Plato
{
    private string nombrePlato;
    private double precio;

    public string NombrePlato
    {
        get { return nombrePlato; }
        set { nombrePlato = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Plato(string nom, double pre)
    {
        nombrePlato = nom;
        precio = pre;
    }
}

class GestionComandas
{
    private List<Plato> platos =
        new List<Plato>();

    public void AgregarPlato()
    {
        Console.Write("Nombre del plato: ");
        string nombre =
            Console.ReadLine();

        Console.Write("Precio: ");
        double precio =
            double.Parse(Console.ReadLine());

        Plato p =
            new Plato(nombre, precio);

        platos.Add(p);
    }

    public void MostrarComanda()
    {
        Console.WriteLine("COMANDA");

        foreach (Plato p in platos)
        {
            Console.WriteLine(
                p.NombrePlato +
                " - $" + p.Precio);
        }

        Console.WriteLine(
            "Cantidad de platos: " +
            platos.Count);
    }

    public void CalcularTotalMesa()
    {
        double total = 0;

        foreach (Plato p in platos)
        {
            total += p.Precio;
        }

        Console.WriteLine(
            "Total: $" + total);
    }

    public void CancelarPlato()
    {
        Console.Write(
            "Plato a cancelar: ");

        string nombre =
            Console.ReadLine();

        Plato encontrado = null;

        foreach (Plato p in platos)
        {
            if (p.NombrePlato == nombre)
            {
                encontrado = p;
            }
        }

        if (encontrado != null)
        {
            platos.Remove(encontrado);
            Console.WriteLine(
                "Plato cancelado.");
        }
        else
        {
            Console.WriteLine(
                "Plato no encontrado.");
        }
    }
}

class Program
{
    static void Main()
    {
        GestionComandas g =
            new GestionComandas();

        for (int i = 0; i < 3; i++)
        {
            g.AgregarPlato();
        }

        g.MostrarComanda();
        g.CalcularTotalMesa();

        g.CancelarPlato();

        Console.WriteLine();
        g.MostrarComanda();
        g.CalcularTotalMesa();
    }
}