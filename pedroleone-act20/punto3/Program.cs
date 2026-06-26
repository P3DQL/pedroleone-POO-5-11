using System;
/*Actividad 3: Estadísticas de visitas a zonas arqueológicas
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
días. Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga
nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.
*/
class Zona
{
    private string nombre;
    private int totalVisitas;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int TotalVisitas
    {
        get { return totalVisitas; }
        set { totalVisitas = value; }
    }

    public void Mostrar()
    {
        Console.WriteLine(
            nombre +
            " - Total visitas: " +
            totalVisitas);
    }
}

class Program
{
    static void Main()
    {
        int[,] visitas =
            new int[3, 4];

        int[] totales =
            new int[3];

        string[] nombres =
        {
            "Zona Maya",
            "Zona Inca",
            "Zona Egipcia"
        };

        Zona[] zonasVisitadas =
            new Zona[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(
                "Cargar visitas de " +
                nombres[i]);

            for (int j = 0; j < 4; j++)
            {
                Console.Write(
                    "Semana " +
                    (j + 1) + ": ");

                visitas[i, j] =
                    int.Parse(
                        Console.ReadLine());

                totales[i] +=
                    visitas[i, j];
            }

            Console.WriteLine();
        }

        Console.WriteLine(
            "TABLA DE VISITAS");

        Console.WriteLine(
            "Zona\tS1\tS2\tS3\tS4\tTotal");

        for (int i = 0; i < 3; i++)
        {
            Console.Write(
                nombres[i] + "\t");

            for (int j = 0; j < 4; j++)
            {
                Console.Write(
                    visitas[i, j] +
                    "\t");
            }

            Console.WriteLine(
                totales[i]);

            zonasVisitadas[i] =
                new Zona();

            zonasVisitadas[i].Nombre =
                nombres[i];

            zonasVisitadas[i]
                .TotalVisitas =
                totales[i];
        }

        Zona mayor =
            zonasVisitadas[0];

        foreach (Zona z
                 in zonasVisitadas)
        {
            if (z.TotalVisitas >
                mayor.TotalVisitas)
            {
                mayor = z;
            }
        }

        Console.WriteLine();
        Console.WriteLine(
            "ZONA MÁS VISITADA");

        mayor.Mostrar();
    }
}
