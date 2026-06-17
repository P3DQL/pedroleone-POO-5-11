using System;
/*3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
     Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
     Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
 */
class Computadora
{
    public string Marca { get; set; }
    public int MemoriaRAM { get; set; }

    public Computadora(string marca, int memoriaRAM)
    {
        Marca = marca;
        MemoriaRAM = memoriaRAM;
    }
}

class Notebook : Computadora
{
    public double TamanoPantalla { get; set; }

    public Notebook(string marca, int memoriaRAM, double tamanoPantalla)
        : base(marca, memoriaRAM)
    {
        TamanoPantalla = tamanoPantalla;
    }

    public void Mostrar()
    {
        Console.WriteLine("NOTEBOOK");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("RAM: " + MemoriaRAM + " GB");
        Console.WriteLine("Pantalla: " + TamanoPantalla + " pulgadas");
    }
}

class Escritorio : Computadora
{
    public int PotenciaFuente { get; set; }

    public Escritorio(string marca, int memoriaRAM, int potenciaFuente)
        : base(marca, memoriaRAM)
    {
        PotenciaFuente = potenciaFuente;
    }

    public void Mostrar()
    {
        Console.WriteLine("PC ESCRITORIO");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("RAM: " + MemoriaRAM + " GB");
        Console.WriteLine("Fuente: " + PotenciaFuente + " Watts");
    }
}

class Program
{
    static void Main()
    {
        Notebook notebook = new Notebook("Lenovo", 16, 15.6);

        Escritorio pc = new Escritorio("HP", 32, 750);

        notebook.Mostrar();

        Console.WriteLine();

        pc.Mostrar();
    }
}