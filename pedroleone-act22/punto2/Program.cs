using System;

class ElementoPantalla
{
    public string nombre;
    public int posX;
    public int posY;

    public ElementoPantalla(
        string n,
        int x,
        int y)
    {
        nombre = n;
        posX = x;
        posY = y;
    }

    public void Mostrar()
    {
        Console.CursorVisible =
            false;

        Console.SetCursorPosition(
            posX,
            posY);

        Console.Write(nombre);
    }
}

class Program
{
    static void Main()
    {
        ElementoPantalla[] e =
        {
            new ElementoPantalla(
                "Jugador", 5, 5),

            new ElementoPantalla(
                "Enemigo", 20, 8),

            new ElementoPantalla(
                "Tesoro", 35, 10),

            new ElementoPantalla(
                "Salida", 50, 15)
        };

        foreach (ElementoPantalla x
                 in e)
        {
            x.Mostrar();
        }

        Console.ReadKey();
    }
}