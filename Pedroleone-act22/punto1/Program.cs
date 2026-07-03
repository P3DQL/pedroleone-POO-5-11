using System;

namespace punto1
{
    /*Actividad 1: Control de horarios en un gimnasio
    Problema:
    Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
    DateTime).
         Implementar un constructor que permita cargar los datos desde consola y otro
        que cargue valores por defecto (sobrecarga de constructores).
         Incluir un método para calcular la duración de la clase usando TimeSpan.
         Crear un vector de 3 clases de gimnasio y mostrar:
            1. La clase que tenga la mayor duración.
            2. El nombre y el horario de inicio de la clase más temprana.
    */
    class ClaseGimnasio
    {
        public string nombreClase;
        public DateTime horaInicio;
        public DateTime horaFin;

        public ClaseGimnasio()
        {
            nombreClase = "Yoga";
            horaInicio = DateTime.Parse("08:00");
            horaFin = DateTime.Parse("09:00");
        }

        public ClaseGimnasio( string nombre, DateTime inicio, DateTime fin)
        {
            nombreClase = nombre;
            horaInicio = inicio;
            horaFin = fin;
        }

        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;
        }
    }

    class Program
    {
        static void Main()
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine( "CLASE " + (i + 1));

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Inicio: ");
                DateTime inicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Fin: ");
                DateTime fin = DateTime.Parse(Console.ReadLine());

                clases[i] =
                    new ClaseGimnasio(nombre, inicio, fin);

                Console.WriteLine();
            }

            ClaseGimnasio mayor = clases[0];

            ClaseGimnasio temprana = clases[0];

            foreach (ClaseGimnasio c in clases)
            {
                if (c.Duracion() > mayor.Duracion())
                {
                    mayor = c;
                }

                if (c.horaInicio <
                    temprana.horaInicio)
                {
                    temprana = c;
                }
            }

            Console.WriteLine("Clase más larga: " + mayor.nombreClase);

            Console.WriteLine("Clase más temprana: " + temprana.nombreClase + " - " + temprana.horaInicio.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
