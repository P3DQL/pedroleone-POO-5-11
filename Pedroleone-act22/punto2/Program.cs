using System;

namespace punto2
{
    /*Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
         Implementar propiedades y un constructor que cargue valores.
         Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
        nombre en pantalla y Console.CursorVisible para ocultar el cursor.
         Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
        consola.
    */
    class ElementoPantalla
    {
        public string nombre;
        public int posX;
        public int posY;

        public ElementoPantalla( string n, int x, int y)
        {
            nombre = n;
            posX = x;
            posY = y;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition( posX, posY);
            Console.Write(nombre);
        }
    }

    class Program
    {
        static void Main()
        {
            ElementoPantalla[] e =
            {
            new ElementoPantalla( "Jugador", 5, 5),
            new ElementoPantalla( "Enemigo", 20, 8),
            new ElementoPantalla( "Tesoro", 35, 10),
            new ElementoPantalla( "Salida", 50, 15)
            };

            foreach (ElementoPantalla x in e)
            {
                x.Mostrar();
            }
            Console.ReadKey();
        }
    }
}