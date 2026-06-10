using System;
/*2. Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.
*/
class Producto
{
    private string nombre;
    private double precio;
    private int stock;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public double Precio
    {
        get { return precio; }
        set
        {
            if (value > 0)
                precio = value;
        }
    }

    public int Stock
    {
        get { return stock; }
        set
        {
            if (value >= 0)
                stock = value;
        }
    }
}

class Inventario
{
    private Producto[] productos = new Producto[3];

    public Inventario()
    {
        productos[0] = new Producto { Nombre = "Mouse", Precio = 15000, Stock = 10 };
        productos[1] = new Producto { Nombre = "Teclado", Precio = 25000, Stock = 5 };
        productos[2] = new Producto { Nombre = "Monitor", Precio = 120000, Stock = 2 };
    }

    public void MostrarProductos()
    {
        Array.Sort(productos, (a, b) => a.Precio.CompareTo(b.Precio));

        Console.WriteLine("Productos ordenados por precio:");

        foreach (Producto p in productos)
        {
            Console.WriteLine(p.Nombre + " - $" + p.Precio + " - Stock: " + p.Stock);
        }

        Console.WriteLine("\nProducto más barato:");
        Console.WriteLine(productos[0].Nombre + " - $" + productos[0].Precio);

        Console.WriteLine("\nProducto más caro:");
        Console.WriteLine(productos[2].Nombre + " - $" + productos[2].Precio);
    }
}

class Program
{
    static void Main()
    {
        Inventario inventario = new Inventario();
        inventario.MostrarProductos();
    }
}