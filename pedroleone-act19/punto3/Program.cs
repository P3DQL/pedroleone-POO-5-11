using System;
/*3. Armar una clase parcial JuegoArcade.
En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
NivelDificultad (de 1 a 5). Valores cargados desde consola
En el segundo archivo, implementar un método que indique si un puntaje ingresado
supera el récord o no.
Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.
 */
public partial class JuegoArcade
{
    private string nombreJuego;
    private int puntajeMaximo;
    private int nivelDificultad;

    public string NombreJuego
    {
        get { return nombreJuego; }
        set { nombreJuego = value; }
    }

    public int PuntajeMaximo
    {
        get { return puntajeMaximo; }
        set { puntajeMaximo = value; }
    }

    public int NivelDificultad
    {
        get { return nivelDificultad; }
        set
        {
            if (value >= 1 && value <= 5)
                nivelDificultad = value;
        }
    }
}

public partial class JuegoArcade
{
    public bool SuperaRecord(int puntaje)
    {
        return puntaje > PuntajeMaximo;
    }
}

class Program
{
    static void Main()
    {
        JuegoArcade juego = new JuegoArcade();

        Console.Write("Nombre del juego: ");
        juego.NombreJuego = Console.ReadLine();

        Console.Write("Puntaje récord: ");
        juego.PuntajeMaximo =
            int.Parse(Console.ReadLine());

        Console.Write("Nivel dificultad (1-5): ");
        juego.NivelDificultad =
            int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("PARTIDA " + (i + 1));

            Console.Write("Jugador: ");
            string jugador = Console.ReadLine();

            Console.Write("Puntaje: ");
            int puntaje =
                int.Parse(Console.ReadLine());

            if (juego.SuperaRecord(puntaje))
            {
                Console.WriteLine(
                    jugador +
                    " rompió el récord de " +
                    juego.NombreJuego
                );
            }
            else
            {
                Console.WriteLine(
                    jugador +
                    " no superó el récord"
                );
            }

            Console.WriteLine();
        }
    }
}