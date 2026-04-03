using System;

class Empleado
{
    private string nombre;
    private double sueldo;

    public void Cargar()
    {
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese el sueldo: ");
        sueldo = double.Parse(Console.ReadLine());
    }

    public void Imprimir()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Sueldo: " + sueldo);
    }

    public void Impuestos()
    {
        if (sueldo > 3000)
        {
            Console.WriteLine("Debe pagar impuestos");
        }
        else
        {
            Console.WriteLine("No paga impuestos");
        }
    }
}

class Program
{
    static void Main()
    {
        Empleado emp = new Empleado();
        emp.Cargar();
        emp.Imprimir();
        emp.Impuestos();

        Console.ReadKey();
    }
}