using System;
using System.Collections.Generic;
/*1-
En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
llegada.
 Crear la clase Documento que contenga como atributos privados:
nombreArchivo (string) y cantidadPaginas (int). Definir sus
propiedades de solo lectura y un constructor que reciba los parámetros nom
y pag.
 Crear la clase ServidorImpresion que administre una lista dinámica de
documentos (List&lt;Documento&gt;).
 Métodos en ServidorImpresion:
1. AgregarDocumento(): Solicitar por teclado los datos de un
documento y agregarlo al final de la lista utilizando .Add().
2. ImprimirSiguiente(): Si la lista no está vacía, simular la
impresión del primer documento de la lista (mostrar sus datos en
consola) y removerlo de la colección mediante .RemoveAt(0). Si está
vacía, advertir que no hay trabajos pendientes.
3. MostrarColaPendiente(): Listar todos los documentos que
están esperando ser impresos y la cantidad total de páginas
acumuladas en la cola de espera utilizando .Count.
*/
class Documento
{
    private string nombreArchivo;
    private int cantidadPaginas;

public string NombreArchivo
    {
        get { return nombreArchivo; }
    }

    public int CantidadPaginas
    {
        get { return cantidadPaginas; }
    }

    public Documento(string nom, int pag)
    {
        nombreArchivo = nom;
        cantidadPaginas = pag;
    }

}

class ServidorImpresion
{
    private List<Documento> documentos =
    new List<Documento>();

public void AgregarDocumento()
    {
        Console.Write("Nombre del archivo: ");
        string nom = Console.ReadLine();

        Console.Write("Cantidad de páginas: ");
        int pag = int.Parse(Console.ReadLine());

        documentos.Add(new Documento(nom, pag));
    }

    public void ImprimirSiguiente()
    {
        if (documentos.Count > 0)
        {
            Console.WriteLine(
                "Imprimiendo: " +
                documentos[0].NombreArchivo);

            Console.WriteLine(
                "Páginas: " +
                documentos[0].CantidadPaginas);

            documentos.RemoveAt(0);
        }
        else
        {
            Console.WriteLine(
                "No hay trabajos pendientes.");
        }
    }

    public void MostrarColaPendiente()
    {
        int total = 0;

        Console.WriteLine(
            "COLA DE IMPRESIÓN");

        foreach (Documento d in documentos)
        {
            Console.WriteLine(
                d.NombreArchivo +
                " - " +
                d.CantidadPaginas +
                " páginas");

            total += d.CantidadPaginas;
        }

        Console.WriteLine(
            "Documentos pendientes: " +
            documentos.Count);

        Console.WriteLine(
            "Total de páginas: " +
            total);
    }

}

class Program
{
    static void Main()
    {
        ServidorImpresion s =
        new ServidorImpresion();

    for (int i = 0; i < 3; i++)
        {
            s.AgregarDocumento();
            Console.WriteLine();
        }

        s.MostrarColaPendiente();

        Console.WriteLine();

        s.ImprimirSiguiente();

        Console.WriteLine();

        s.MostrarColaPendiente();
    }

}
