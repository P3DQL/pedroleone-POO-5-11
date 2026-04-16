using System;

class Program
{
    /* 3. Desarrollar una clase que represente un empleado y tenga los siguientes
       métodos: cargar el nombre y el sueldo, imprimir el nombre y el sueldo, e
       informar si debe pagar impuestos (si el sueldo es mayor a 3000 paga impuestos).
        */
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
    static void Main()
    {
        Program p = new Program();
        p.Cargar();
        p.Imprimir();
        p.Impuestos();

        Console.ReadKey();
    }
}