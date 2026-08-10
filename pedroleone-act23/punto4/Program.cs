using System;
using System.Collections.Generic;
/*4-
Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.
 Crear la clase colaboradora PanelDomotico que administre un objeto
List&lt;DispositivoInteligente&gt;.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto.*/
class DispositivoInteligente
{
    private string nombreDispositivo;
    private double consumoWatts;
public string NombreDispositivo
    {
        get { return nombreDispositivo; }
        set { nombreDispositivo = value; }
    }

    public double ConsumoWatts
    {
        get { return consumoWatts; }
        set { consumoWatts = value; }
    }

    public DispositivoInteligente(
        string nom,
        double watts)
    {
        nombreDispositivo = nom;
        consumoWatts = watts;
    }

}

class PanelDomotico
{
    private List<DispositivoInteligente>
    dispositivos =
    new List<DispositivoInteligente>();

public PanelDomotico()
    {
        string respuesta;

        do
        {
            Console.Write(
                "Nombre del dispositivo: ");

            string nom =
                Console.ReadLine();

            Console.Write(
                "Consumo en watts: ");

            double watts =
                double.Parse(
                    Console.ReadLine());

            dispositivos.Add(
                new DispositivoInteligente(
                    nom,
                    watts));

            Console.Write(
                "¿Agregar otro? (S/N): ");

            respuesta =
                Console.ReadLine();

        } while (respuesta == "S");
    }

    public void MostrarDispositivos()
    {
        foreach (DispositivoInteligente d
                 in dispositivos)
        {
            Console.WriteLine(
                d.NombreDispositivo +
                " - " +
                d.ConsumoWatts +
                " W");
        }
    }

    public void CalcularConsumoTotal()
    {
        double total = 0;

        foreach (DispositivoInteligente d
                 in dispositivos)
        {
            total += d.ConsumoWatts;
        }

        Console.WriteLine(
            "Consumo total: " +
            total +
            " W");
    }

    public void DesconectarDispositivo()
    {
        Console.Write(
            "Dispositivo a desconectar: ");

        string nom =
            Console.ReadLine();

        for (int i = 0;
             i < dispositivos.Count;
             i++)
        {
            if (dispositivos[i]
                    .NombreDispositivo
                == nom)
            {
                dispositivos.RemoveAt(i);

                Console.WriteLine(
                    "Dispositivo desconectado");

                return;
            }
        }

        Console.WriteLine(
            "No se encontró el dispositivo");
    }

}

class Program
{
    static void Main()
    {
        PanelDomotico p =
        new PanelDomotico();

    Console.WriteLine();

        p.MostrarDispositivos();

        Console.WriteLine();

        p.CalcularConsumoTotal();

        Console.WriteLine();

        p.DesconectarDispositivo();

        Console.WriteLine();

        p.MostrarDispositivos();
    }

}
