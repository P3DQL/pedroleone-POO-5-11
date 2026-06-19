using System;
/*2.
Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
La clase CriaturaMarina debe tener como atributos privados: Especie (string),
ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
● La profundidad óptima sea estrictamente mayor a cero (0).
● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
nivel de salinidad para sobrevivir.
 */
class CriaturaMarina
{
    private string especie;
    private int profundidadOptima;
    private int nivelSalinidad;

    public string Especie
    {
        get { return especie; }
        set { especie = value; }
    }

    public int ProfundidadOptima
    {
        get { return profundidadOptima; }
        set
        {
            if (value > 0)
                profundidadOptima = value;
        }
    }

    public int NivelSalinidad
    {
        get { return nivelSalinidad; }
        set
        {
            if (value >= 1 && value <= 100)
                nivelSalinidad = value;
            else
                nivelSalinidad = 35;
        }
    }
}

class HabitatAcuatico
{
    private CriaturaMarina[] criaturas = new CriaturaMarina[3];

    public void CargarCriaturas()
    {
        for (int i = 0; i < 3; i++)
        {
            criaturas[i] = new CriaturaMarina();

            Console.WriteLine("CRIATURA " + (i + 1));

            Console.Write("Especie: ");
            criaturas[i].Especie = Console.ReadLine();

            Console.Write("Profundidad óptima: ");
            criaturas[i].ProfundidadOptima =
                int.Parse(Console.ReadLine());

            Console.Write("Nivel de salinidad: ");
            criaturas[i].NivelSalinidad =
                int.Parse(Console.ReadLine());

            Console.WriteLine();
        }
    }

    public void MostrarCriaturas()
    {
        Array.Sort(criaturas, (a, b) =>
            a.ProfundidadOptima.CompareTo(b.ProfundidadOptima));

        Console.WriteLine("CRIATURAS ORDENADAS");

        foreach (CriaturaMarina c in criaturas)
        {
            Console.WriteLine(
                c.Especie +
                " - Profundidad: " +
                c.ProfundidadOptima +
                " m - Salinidad: " +
                c.NivelSalinidad
            );
        }

        CriaturaMarina mayorSalinidad = criaturas[0];

        foreach (CriaturaMarina c in criaturas)
        {
            if (c.NivelSalinidad > mayorSalinidad.NivelSalinidad)
                mayorSalinidad = c;
        }

        Console.WriteLine();
        Console.WriteLine(
            "Mayor nivel de salinidad: " +
            mayorSalinidad.Especie
        );
    }
}

class Program
{
    static void Main()
    {
        HabitatAcuatico habitat = new HabitatAcuatico();

        habitat.CargarCriaturas();

        habitat.MostrarCriaturas();
    }
}