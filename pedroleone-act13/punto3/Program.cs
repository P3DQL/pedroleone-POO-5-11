using System;

namespace punto3
{
    /*3. Plantear una clase Club y otra clase Socio.
        La clase Socio debe tener los siguientes atributos privados: nombre y la
        antigüedad en el club (en años). En el constructor pedir la carga del nombre y
        su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
        Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
        antigüedad en el club.
    */
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese antigüedad: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }

        public string RetornarNombre()
        {
            return nombre;
        }
    }

    class Club
    {
        private Socio socio1;
        private Socio socio2;
        private Socio socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorAntiguedad()
        {
            Socio mayor = socio1;

            if (socio2.RetornarAntiguedad() > mayor.RetornarAntiguedad())
            {
                mayor = socio2;
            }

            if (socio3.RetornarAntiguedad() > mayor.RetornarAntiguedad())
            {
                mayor = socio3;
            }

            Console.WriteLine("Socio con mayor antigüedad: " + mayor.RetornarNombre());
        }

        static void Main(string[] args)
        {
            Club c = new Club();

            c.MayorAntiguedad();

            Console.ReadKey();
        }
    }
}