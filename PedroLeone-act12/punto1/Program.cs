using System;

namespace Ejercicio1
{
    /*1. Sistema de Logística: Envíos por Sucursal
    Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
    cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
          represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
    1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
       paquetes se enviaron hoy para definir el tamaño de su fila.
    2. Cargar el peso de cada paquete.
    3. Imprimir el peso de todos los paquetes organizados por sucursal.
    4. Calcular e informar el peso total despachado por cada sucursal.
    5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
       pertenece.
     */
    class Program
    {
        static string[] sucursales = new string[3];
        static int[][] paquetes = new int[3][];

        static void Cargar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre de la sucursal: ");
                sucursales[i] = Console.ReadLine();

                Console.Write("Cantidad de paquetes: ");
                int cant = int.Parse(Console.ReadLine());

                paquetes[i] = new int[cant];

                for (int j = 0; j < cant; j++)
                {
                    Console.Write("Ingrese peso del paquete: ");
                    paquetes[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void Mostrar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sucursal: " + sucursales[i]);

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.Write(paquetes[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void PesoTotal()
        {
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    suma += paquetes[i][j];
                }

                Console.WriteLine("Peso total de " + sucursales[i] + ": " + suma);
            }
        }

        static void PaqueteMayor()
        {
            int mayor = paquetes[0][0];
            string sucursal = sucursales[0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    if (paquetes[i][j] > mayor)
                    {
                        mayor = paquetes[i][j];
                        sucursal = sucursales[i];
                    }
                }
            }

            Console.WriteLine("Paquete más pesado: " + mayor);
            Console.WriteLine("Sucursal: " + sucursal);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Mostrar();
            p.PesoTotal();
            p.PaqueteMayor();

            Console.ReadKey();
        }
    }
}