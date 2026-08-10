using System;
using System.Collections.Generic;
/*2-
Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List&lt;Dron&gt;.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.
*/
class Dron
{
    private string codigo;
    private int nivelBateria;

public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public int NivelBateria
    {
        get { return nivelBateria; }
        set { nivelBateria = value; }
    }

    public Dron(string cod, int bat)
    {
        codigo = cod;
        nivelBateria = bat;
    }

}

class CentroControl
{
    private List<Dron> drones = new List<Dron>();

public CentroControl()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("DRON " + (i + 1));

            Console.Write("Código: ");
            string cod = Console.ReadLine();

            Console.Write("Batería: ");
            int bat = int.Parse(Console.ReadLine());

            drones.Add(new Dron(cod, bat));

            Console.WriteLine();
        }
    }

    public void ListarFlota()
    {
        foreach (Dron d in drones)
        {
            Console.WriteLine(
                d.Codigo + " - " +
                d.NivelBateria + "%");
        }
    }

    public void RemoverDronesBajos()
    {
        for (int i = drones.Count - 1;
             i >= 0;
             i--)
        {
            if (drones[i].NivelBateria <= 15)
                drones.RemoveAt(i);
        }
    }

    public void MostrarDronesRestantes()
    {
        Console.WriteLine(
            "Drones operativos: " +
            drones.Count);

        ListarFlota();
    }

}

class Program
{
    static void Main()
    {
        CentroControl c =
        new CentroControl();

    Console.WriteLine(
        "FLOTA INICIAL");

        c.ListarFlota();

        c.RemoverDronesBajos();

        Console.WriteLine();
        Console.WriteLine(
            "FLOTA ACTUALIZADA");

        c.MostrarDronesRestantes();
    }

}
