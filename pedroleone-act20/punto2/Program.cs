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
            "Código: " + codigo +
            " | Peso: " + peso +
            " kg | Destino: " + destino
        );
    }
}

class Despachador
{
    public Paquete[] paquetes =
        new Paquete[5];

    public void RegistrarPaquete(
        int posicion,
        Paquete p)
    {
        paquetes[posicion] = p;
    }
}

class Program
{
    static void Main()
    {
        Despachador despachador =
            new Despachador();

        for (int i = 0; i < 5; i++)
        {
            Paquete p = new Paquete();

            Console.WriteLine(
                "PAQUETE " + (i + 1));

            Console.Write("Código: ");
            p.Codigo =
                Console.ReadLine();

            Console.Write("Peso: ");
            p.Peso =
                double.Parse(Console.ReadLine());

            Console.Write("Destino: ");
            p.Destino =
                Console.ReadLine();

            despachador.RegistrarPaquete(
                i, p);

            Console.WriteLine();
        }

        Console.WriteLine(
            "PAQUETES REGISTRADOS");

        foreach (Paquete p in
                 despachador.paquetes)
        {
            p.Mostrar();
        }

        int mayores10 = 0;
        int nacionales = 0;

        foreach (Paquete p in
                 despachador.paquetes)
        {
            if (p.Peso > 10)
                mayores10++;

            if (p.Destino ==
                "Argentina")
                nacionales++;
        }

        Console.WriteLine();
        Console.WriteLine(
            "Paquetes mayores a 10 kg: "
            + mayores10);

        Console.WriteLine(
            "Paquetes nacionales: "
            + nacionales);
    }
}