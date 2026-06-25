using System;
/*2. Crear una clase parcial Libro.
En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
cantidad de páginas sea mayor a 10. Valores cargados desde consola
En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
si el libro es corto (menos de 100 páginas) o largo.
Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
*/
public partial class Libro
{
    private string titulo;
    private string autor;
    private int paginas;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public int Paginas
    {
        get { return paginas; }
        set
        {
            if (value > 10)
                paginas = value;
        }
    }
}

public partial class Libro
{
    public void Resumen()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);

        if (Paginas < 100)
            Console.WriteLine("Libro corto");
        else
            Console.WriteLine("Libro largo");
    }
}

class Program
{
    static void Main()
    {
        Libro[] libros = new Libro[2];

        for (int i = 0; i < 2; i++)
        {
            libros[i] = new Libro();

            Console.WriteLine("LIBRO " + (i + 1));

            Console.Write("Título: ");
            libros[i].Titulo = Console.ReadLine();

            Console.Write("Autor: ");
            libros[i].Autor = Console.ReadLine();

            Console.Write("Páginas: ");
            libros[i].Paginas =
                int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        foreach (Libro l in libros)
        {
            l.Resumen();
            Console.WriteLine();
        }

        Libro mayor = libros[0];

        foreach (Libro l in libros)
        {
            if (l.Paginas > mayor.Paginas)
                mayor = l;
        }

        Console.WriteLine("Libro más extenso:");
        Console.WriteLine(mayor.Titulo +
                          " - " + mayor.Paginas +
                          " páginas");
    }
}