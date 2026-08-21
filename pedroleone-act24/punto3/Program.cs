using System;
using System.Collections.Generic;
/*9-
Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
realizar el seguimiento académico de sus materias.
 Crear la clase Estudiante que contenga como atributos privados:
nombreCompleto (string) y calificacion (double). Definir sus propiedades
de solo lectura y un constructor que reciba nom y cal.
 Crear la clase GestionAcademica que administre una lista de objetos
List.
 Métodos en GestionAcademica:
o CargarEstudiantes(): Solicitar por teclado nombres y
calificaciones para agregar estudiantes a la lista mediante .Add(). La
carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
nombre.
o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
junto a la cantidad total de inscriptos mediante la propiedad .Count.
o FiltrarAprobados(): Recorrer la lista e imprimir en consola
únicamente aquellos estudiantes cuya calificación sea mayor o igual
a 6.0.
o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
utilizando los métodos de búsqueda y remoción de listas, eliminarlo
de la colección si se encuentra presente.
*/
class Estudiante
{
    private string nombreCompleto;
    private double calificacion;

    public string NombreCompleto
    {
        get { return nombreCompleto; }
    }

    public double Calificacion
    {
        get { return calificacion; }
    }

    public Estudiante(
        string nom,
        double cal)
    {
        nombreCompleto = nom;
        calificacion = cal;
    }
}

class GestionAcademica
{
    private List<Estudiante> estudiantes =
        new List<Estudiante>();

    public void CargarEstudiantes()
    {
        string nombre = "";

        while (nombre != "FIN")
        {
            Console.Write(
                "Nombre del estudiante: ");

            nombre = Console.ReadLine();

            if (nombre != "FIN")
            {
                Console.Write(
                    "Calificación: ");

                double calificacion =
                    double.Parse(
                        Console.ReadLine());

                estudiantes.Add(
                    new Estudiante(
                        nombre,
                        calificacion));
            }
        }
    }

    public void ListarEstudiantes()
    {
        Console.WriteLine(
            "ESTUDIANTES");

        foreach (Estudiante e
                 in estudiantes)
        {
            Console.WriteLine(
                e.NombreCompleto +
                " - " +
                e.Calificacion);
        }

        Console.WriteLine(
            "Cantidad de inscriptos: " +
            estudiantes.Count);
    }

    public void FiltrarAprobados()
    {
        Console.WriteLine(
            "ESTUDIANTES APROBADOS");

        foreach (Estudiante e
                 in estudiantes)
        {
            if (e.Calificacion >= 6)
            {
                Console.WriteLine(
                    e.NombreCompleto +
                    " - " +
                    e.Calificacion);
            }
        }
    }

    public void DarDeBaja()
    {
        Console.Write(
            "Nombre a dar de baja: ");

        string nombre =
            Console.ReadLine();

        Estudiante encontrado = null;

        foreach (Estudiante e
                 in estudiantes)
        {
            if (e.NombreCompleto == nombre)
            {
                encontrado = e;
            }
        }

        if (encontrado != null)
        {
            estudiantes.Remove(encontrado);

            Console.WriteLine(
                "Estudiante eliminado.");
        }
        else
        {
            Console.WriteLine(
                "Estudiante no encontrado.");
        }
    }
}

class Program
{
    static void Main()
    {
        GestionAcademica g =
            new GestionAcademica();

        g.CargarEstudiantes();

        Console.WriteLine();

        g.ListarEstudiantes();

        Console.WriteLine();

        g.FiltrarAprobados();

        Console.WriteLine();

        g.DarDeBaja();

        Console.WriteLine();

        g.ListarEstudiantes();
    }
}