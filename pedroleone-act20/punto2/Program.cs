using System;
/*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).
*/
class Paquete
{
    private string codigo;
    private double peso;
    private string destino;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value > 0)
                peso = value;
        }
    }

    public string Destino
    {
        get { return destino; }
        set { destino = value; }
    }

    public void Mostrar()
    {
        Console.WriteLine(
            "Código: " + codigo);
        Console.WriteLine(
            "Peso: " + peso +
            " kg");
        Console.WriteLine(
            "Destino: " + destino);
    }
}

class Despachador
{
    private Paquete[] paquetes =
        new Paquete[5];

    public void RegistrarPaquete(
        int posicion,
        Paquete p)
    {
        paquetes[posicion] = p;
    }

    public void MostrarPaquetes()
    {
        foreach (Paquete p in paquetes)
        {
            p.Mostrar();

            Console.WriteLine();
        }
    }

    public int PaquetesPesados()
    {
        int contador = 0;

        foreach (Paquete p in paquetes)
        {
            if (p.Peso > 10)
                contador++;
        }

        return contador;
    }

    public int PaquetesNacionales()
    {
        int contador = 0;

        foreach (Paquete p in paquetes)
        {
            if (p.Destino ==
                "Argentina")
            {
                contador++;
            }
        }

        return contador;
    }
}

class Program
{
    static void Main()
    {
        Despachador d =
            new Despachador();

        for (int i = 0; i < 5; i++)
        {
            Paquete p =
                new Paquete();

            Console.WriteLine(
                "PAQUETE " +
                (i + 1));

            Console.Write(
                "Código: ");
            p.Codigo =
                Console.ReadLine();

            Console.Write(
                "Peso: ");
            p.Peso =
                double.Parse(
                    Console.ReadLine());

            Console.Write(
                "Destino: ");
            p.Destino =
                Console.ReadLine();

            d.RegistrarPaquete(
                i, p);

            Console.WriteLine();
        }

        Console.WriteLine(
            "PAQUETES REGISTRADOS");

        d.MostrarPaquetes();

        Console.WriteLine(
            "Mayores a 10 kg: " +
            d.PaquetesPesados());

        Console.WriteLine(
            "Destinos nacionales: " +
            d.PaquetesNacionales());
    }
}
