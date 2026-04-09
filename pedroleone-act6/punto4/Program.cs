using System;

class Operaciones
{
    private int num1, num2;
/*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
    calcular su suma, resta, multiplicación y división, cada una en un método,
    imprimir dichos resultados.
*/
    public void Cargar()
    {
        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());
    }

    public void Suma()
    {
        Console.WriteLine("Suma: " + (num1 + num2));
    }

    public void Resta()
    {
        Console.WriteLine("Resta: " + (num1 - num2));
    }

    public void Multiplicacion()
    {
        Console.WriteLine("Multiplicación: " + (num1 * num2));
    }

    public void Division()
    {
        Console.WriteLine("División: " + ((double)num1 / num2));
    }
}

class Program
{
    static void Main()
    {
        Operaciones op = new Operaciones();
        op.Cargar();
        op.Suma();
        op.Resta();
        op.Multiplicacion();
        op.Division();

        Console.ReadKey();
    }
}
