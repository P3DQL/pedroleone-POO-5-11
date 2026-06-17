using System;
/*2. Catálogo de Películas (Encapsulación, Validación y Composición)
    Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
    La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
    películas ordenadas de mayor a menor en base a su duración. Además, el método debe
    informar el título de la película con mejor calificación y cuál es la película más corta del
    catálogo.
 */
class Pelicula
{
    private string titulo;
    private int duracionMinutos;
    private int calificacion;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public int DuracionMinutos
    {
        get { return duracionMinutos; }
        set
        {
            if (value > 0)
                duracionMinutos = value;
        }
    }

    public int Calificacion
    {
        get { return calificacion; }
        set
        {
            if (value >= 1 && value <= 5)
                calificacion = value;
            else
                calificacion = 1;
        }
    }
}

class Catalogo
{
    private Pelicula[] peliculas = new Pelicula[3];

    public Catalogo()
    {
        peliculas[0] = new Pelicula
        {
            Titulo = "Avatar",
            DuracionMinutos = 180,
            Calificacion = 5
        };

        peliculas[1] = new Pelicula
        {
            Titulo = "Toy Story",
            DuracionMinutos = 90,
            Calificacion = 4
        };

        peliculas[2] = new Pelicula
        {
            Titulo = "Titanic",
            DuracionMinutos = 195,
            Calificacion = 5
        };
    }

    public void MostrarPeliculas()
    {
        Array.Sort(peliculas, (a, b) =>
            b.DuracionMinutos.CompareTo(a.DuracionMinutos));

        Console.WriteLine("PELÍCULAS ORDENADAS POR DURACIÓN");

        foreach (Pelicula p in peliculas)
        {
            Console.WriteLine(
                p.Titulo + " - " +
                p.DuracionMinutos + " min - " +
                "Calificación: " + p.Calificacion
            );
        }

        Pelicula mejor = peliculas[0];
        Pelicula masCorta = peliculas[0];

        foreach (Pelicula p in peliculas)
        {
            if (p.Calificacion > mejor.Calificacion)
                mejor = p;

            if (p.DuracionMinutos < masCorta.DuracionMinutos)
                masCorta = p;
        }

        Console.WriteLine();
        Console.WriteLine("Película con mejor calificación: " + mejor.Titulo);

        Console.WriteLine("Película más corta: " + masCorta.Titulo);
    }
}

class Program
{
    static void Main()
    {
        Catalogo catalogo = new Catalogo();

        catalogo.MostrarPeliculas();
    }
}