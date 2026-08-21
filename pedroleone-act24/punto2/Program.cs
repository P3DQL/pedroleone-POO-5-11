using System;
using System.Collections.Generic;
/*8-
Una farmacia controla el nivel de stock de sus medicamentos para evitar el
desabastecimiento de insumos esenciales.
 Crear la clase Medicamento que contenga los atributos privados: nombre
(string) y stock (int). Definir sus propiedades correspondientes. Su
constructor debe recibir nom y stk.
 Crear la clase ControlFarmacia que administre una lista de objetos List.
 Métodos en ControlFarmacia:
o Un constructor que cargue por teclado una lista inicial de 4
medicamentos ingresando sus nombres y stock.
o ListarStock(): Mostrar la lista de medicamentos en pantalla.

o RemoverAgotados(): Recorrer la lista y remover por completo de
la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
o MostrarMedicamentosDisponibles(): Imprimir la lista
actualizada y la cantidad de productos disponibles en el inventario
utilizando la propiedad .Count.
*/
class Medicamento
{
    private string nombre;
    private int stock;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    public Medicamento(
        string nom,
        int stk)
    {
        nombre = nom;
        stock = stk;
    }
}

class ControlFarmacia
{
    private List<Medicamento> medicamentos =
        new List<Medicamento>();

    public ControlFarmacia()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(
                "MEDICAMENTO " + (i + 1));

            Console.Write("Nombre: ");
            string nombre =
                Console.ReadLine();

            Console.Write("Stock: ");
            int stock =
                int.Parse(Console.ReadLine());

            medicamentos.Add(
                new Medicamento(
                    nombre, stock));
        }
    }

    public void ListarStock()
    {
        Console.WriteLine(
            "STOCK");

        foreach (Medicamento m
                 in medicamentos)
        {
            Console.WriteLine(
                m.Nombre +
                " - Stock: " +
                m.Stock);
        }
    }

    public void RemoverAgotados()
    {
        for (int i = medicamentos.Count - 1;
             i >= 0;
             i--)
        {
            if (medicamentos[i].Stock == 0)
            {
                medicamentos.RemoveAt(i);
            }
        }
    }

    public void MostrarMedicamentosDisponibles()
    {
        Console.WriteLine(
            "MEDICAMENTOS DISPONIBLES");

        foreach (Medicamento m
                 in medicamentos)
        {
            Console.WriteLine(
                m.Nombre +
                " - Stock: " +
                m.Stock);
        }

        Console.WriteLine(
            "Cantidad disponible: " +
            medicamentos.Count);
    }
}

class Program
{
    static void Main()
    {
        ControlFarmacia farmacia =
            new ControlFarmacia();

        Console.WriteLine();

        farmacia.ListarStock();

        farmacia.RemoverAgotados();

        Console.WriteLine();

        farmacia.MostrarMedicamentosDisponibles();
    }
}