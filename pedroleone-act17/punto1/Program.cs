using System;
/*1. Personal de un Gimnasio (Herencia Simple y Propiedades)
    Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
    método para imprimir estos datos básicos.
    Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    para imprimir todos los datos del profesor (incluyendo los heredados).
    En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.
 */
class PersonaGimnasio
{
    private string nombre;
    private string dni;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string DNI
    {
        get { return dni; }
        set { dni = value; }
    }

    public void ImprimirDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
    }
}

class Profesor : PersonaGimnasio
{
    private string especialidad;

    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }

    public void ImprimirProfesor()
    {
        ImprimirDatos();
        Console.WriteLine("Especialidad: " + especialidad);
    }
}

class Program
{
    static void Main()
    {
        PersonaGimnasio persona = new PersonaGimnasio();

        persona.Nombre = "Carlos";
        persona.DNI = "250";

        Console.WriteLine("PERSONA DEL GIMNASIO");
        persona.ImprimirDatos();

        Console.WriteLine();

        Profesor profesor = new Profesor();

        profesor.Nombre = "Laura";
        profesor.DNI = "305";
        profesor.Especialidad = "Musculación";

        Console.WriteLine("PROFESOR");
        profesor.ImprimirProfesor();
    }
}