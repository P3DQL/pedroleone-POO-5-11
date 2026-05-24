using System;

namespace punto2
{
    /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.
    */
    class Operaciones
    {
        private int valor1;
        private int valor2;

        public Operaciones()
        {
            Console.Write("Ingrese primer valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            Console.WriteLine("Suma: " + (valor1 + valor2));
        }

        public void Resta()
        {
            Console.WriteLine("Resta: " + (valor1 - valor2));
        }

        public void Multiplicacion()
        {
            Console.WriteLine("Multiplicación: " + (valor1 * valor2));
        }

        public void Division()
        {
            Console.WriteLine("División: " + (valor1 / valor2));
        }

        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();

            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();

            Console.ReadKey();
        }
    }
}