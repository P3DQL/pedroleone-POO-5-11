using System;
/*4. Armar tres clases: Animal, Mamífero y Perro.
La clase Animal debe tener un atributo especie.
La clase Mamífero, que hereda de Animal, debe tener un atributo
tipoAlimentacion.
La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
Cada clase debe tener un constructor que reciba los datos correspondientes
y los imprima indicando a qué clase pertenecen. Los datos deben ser
asignados previamente
Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
constructores.
*/
class Animal
{
    protected string especie;

    public Animal(string especie)
    {
        this.especie = especie;
        Console.WriteLine("Constructor Animal");
        Console.WriteLine("Especie: " + especie);
    }
}

class Mamifero : Animal
{
    protected string tipoAlimentacion;

    public Mamifero(string especie, string tipoAlimentacion)
        : base(especie)
    {
        this.tipoAlimentacion = tipoAlimentacion;
        Console.WriteLine("Constructor Mamífero");
        Console.WriteLine("Alimentación: " + tipoAlimentacion);
    }
}

class Perro : Mamifero
{
    private string nombre;

    public Perro(string especie, string tipoAlimentacion, string nombre)
        : base(especie, tipoAlimentacion)
    {
        this.nombre = nombre;
        Console.WriteLine("Constructor Perro");
        Console.WriteLine("Nombre: " + nombre);
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro("Canino", "Carnívoro", "Firulais");
    }
}