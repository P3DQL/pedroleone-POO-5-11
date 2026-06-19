using System;
/*3.
Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
realice su asignación.
Luego, definir dos clases derivadas de la clase base:
● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
soportada en atmósferas).
● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
clase SondaExploradora mediante el uso explícito de la palabra clave base.
En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
parámetros unificados por consola.
 */
class SondaExploradora
{
    public string Modelo { get; set; }
    public int AutonomiaMinutos { get; set; }

    public SondaExploradora(string modelo, int autonomiaMinutos)
    {
        Modelo = modelo;
        AutonomiaMinutos = autonomiaMinutos;
    }
}

class SondaSubmarina : SondaExploradora
{
    public int PresionMaximaAtm { get; set; }

    public SondaSubmarina(
        string modelo,
        int autonomiaMinutos,
        int presionMaximaAtm)
        : base(modelo, autonomiaMinutos)
    {
        PresionMaximaAtm = presionMaximaAtm;
    }

    public void Mostrar()
    {
        Console.WriteLine("SONDA SUBMARINA");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Autonomía: " + AutonomiaMinutos + " min");
        Console.WriteLine("Presión máxima: " +
                          PresionMaximaAtm + " atm");
    }
}

class RoverTerrestre : SondaExploradora
{
    public int CantidadRuedas { get; set; }

    public RoverTerrestre(
        string modelo,
        int autonomiaMinutos,
        int cantidadRuedas)
        : base(modelo, autonomiaMinutos)
    {
        CantidadRuedas = cantidadRuedas;
    }

    public void Mostrar()
    {
        Console.WriteLine("ROVER TERRESTRE");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Autonomía: " + AutonomiaMinutos + " min");
        Console.WriteLine("Cantidad de ruedas: " +
                          CantidadRuedas);
    }
}

class Program
{
    static void Main()
    {
        SondaSubmarina submarina =
            new SondaSubmarina("DeepExplorer", 300, 150);

        RoverTerrestre rover =
            new RoverTerrestre("MarsRover", 500, 6);

        submarina.Mostrar();

        Console.WriteLine();

        rover.Mostrar();
    }
}