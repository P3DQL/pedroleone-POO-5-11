using System;
namespace punto2
{
    class Program
    {
        /*2. Gestión de Complejo de Cine
            Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
            asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
            ● Definir una matriz irregular de 4 filas para representar los asientos.
            ● Métodos:
            1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
            intervención del operador).
            2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
            espectador en un asiento específico (fila y columna).
            3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
            en cada asiento.
            4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
            5. Informar cuál es el promedio de edad de los espectadores de todo el
            complejo.
        */
        public int[][] salas;
        public void Crear()
        {
            salas = new int[4][];

            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }
        public void VentaEntrada()
        {
            int sala, asiento, edad;

            Console.Write("Ingrese sala (0 a 3): ");
            sala = int.Parse(Console.ReadLine());

            Console.Write("Ingrese asiento: ");
            asiento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            salas[sala][asiento] = edad;
        }
        public void Mostrar()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                Console.WriteLine("Sala " + (i + 1));
                for (int j = 0; j < salas[i].Length; j++)
                {
                    Console.Write(salas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MenoresEdad()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                int menores = 0;
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0 && salas[i][j] < 18)
                    {
                        menores++;
                    }
                }
                Console.WriteLine("Menores en sala " + (i + 1) + ": " + menores);
            }
        }
        public void PromedioEdades()
        {
            int suma = 0;
            int cantidad = 0;
            for (int i = 0; i < salas.Length; i++)
            {
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0)
                    {
                        suma += salas[i][j];
                        cantidad++;
                    }
                }
            }
            int promedio = suma / cantidad;
            Console.WriteLine("Promedio de edades: " + promedio);
        }
        public void Main(string[] args)
        {
            Program p = new Program();
            p.Crear();
            p.VentaEntrada();
            p.Mostrar();
            p.MenoresEdad();
            p.PromedioEdades();

            Console.ReadKey();
        }
    }
}
