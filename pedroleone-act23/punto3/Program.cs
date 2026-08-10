using System;
using System.Collections.Generic;
/*3-
Un centro de conservación marina registra de forma dinámica las especies de
mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
 Crear la clase MonitoreoCostero que contenga como atributo privado
una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
 Métodos en MonitoreoCostero:
1. CargarAvistamientos(): Solicitar por teclado nombres de
especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
&quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
cuando el usuario ingresa la palabra &quot;FIN&quot;.
2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
organizada alfabéticamente de la A a la Z utilizando el método
.Sort().
3. MostrarReporteInvertido(): Imprimir la lista organizada de la
Z a la A combinando .Sort() con el método .Reverse().
4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
animal y, utilizando los métodos de búsqueda de listas, informar si la
especie fue divisada en la costa durante el día.
 */
class MonitoreoCostero
{
    private List<string> especiesDetectadas =
    new List<string>();

public void CargarAvistamientos()
    {
        string especie;

        do
        {
            Console.Write(
                "Especie (FIN para terminar): ");

            especie = Console.ReadLine();

            if (especie != "FIN")
                especiesDetectadas.Add(especie);

        } while (especie != "FIN");
    }

    public void MostrarReporteOrdenado()
    {
        especiesDetectadas.Sort();

        Console.WriteLine(
            "REPORTE A-Z");

        foreach (string e in especiesDetectadas)
            Console.WriteLine(e);
    }

    public void MostrarReporteInvertido()
    {
        especiesDetectadas.Sort();
        especiesDetectadas.Reverse();

        Console.WriteLine(
            "REPORTE Z-A");

        foreach (string e in especiesDetectadas)
            Console.WriteLine(e);
    }

    public void BuscarEspecie()
    {
        Console.Write(
            "Buscar especie: ");

        string buscar =
            Console.ReadLine();

        if (especiesDetectadas.Contains(buscar))
            Console.WriteLine(
                "La especie fue detectada");
        else
            Console.WriteLine(
                "La especie no fue detectada");
    }

}

class Program
{
    static void Main()
    {
        MonitoreoCostero m =
        new MonitoreoCostero();

    m.CargarAvistamientos();

        Console.WriteLine();

        m.MostrarReporteOrdenado();

        Console.WriteLine();

        m.MostrarReporteInvertido();

        Console.WriteLine();

        m.BuscarEspecie();
    }

}
