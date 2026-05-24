using System;

namespace punto1
{
    /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)
    */
    class Empleado
    {
        private string nombre;
        private int sueldo;

        public Empleado()
        {
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado e = new Empleado();

            e.Imprimir();
            e.Impuestos();

            Console.ReadKey();
        }
    }
}