using System;

/*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.
*/

class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public void Imprimir()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

class Empleado : Persona
{
    private double sueldo;

    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value; }
    }

    public void ImprimirSueldo()
    {
        Console.WriteLine("Sueldo: $" + sueldo);
    }
}

class Program
{
    static void Main()
    {
        Persona persona = new Persona();

        Console.Write("Ingrese nombre de la persona: ");
        persona.Nombre = Console.ReadLine();

        Console.Write("Ingrese edad de la persona: ");
        persona.Edad = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDATOS PERSONA");
        persona.Imprimir();

        Empleado empleado = new Empleado();

        Console.Write("\nIngrese nombre del empleado: ");
        empleado.Nombre = Console.ReadLine();

        Console.Write("Ingrese edad del empleado: ");
        empleado.Edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sueldo del empleado: ");
        empleado.Sueldo = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDATOS EMPLEADO");
        empleado.Imprimir();
        empleado.ImprimirSueldo();
    }
}
