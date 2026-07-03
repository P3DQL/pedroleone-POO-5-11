using System;

namespace punto4
{
    /*Actividad 4: Gestión de vuelos
    Problema:

    Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
         Usar la palabra clave this en el constructor para diferenciar los parámetros de
        los atributos.
         Crear un método para calcular la duración del vuelo (TimeSpan).
         Cargar un vector con 4 vuelos y mostrar:
            1. El código y duración del vuelo más largo.
            2. El código del vuelo que salga más temprano.
    */
    class Vuelo
    {
        public string codigo;
        public DateTime horaSalida;
        public DateTime horaLlegada;

        public Vuelo( string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan Duracion()
        {
            return horaLlegada - horaSalida;
        }
    }

    class Program
    {
        static void Main()
        {
            Vuelo[] vuelos = new Vuelo[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write( "Código: ");
                string codigo = Console.ReadLine();

                Console.Write(  "Hora salida: ");
                DateTime salida = DateTime.Parse(Console.ReadLine());

                Console.Write( "Hora llegada: ");

                DateTime llegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo( codigo, salida, llegada);
                Console.WriteLine();
            }

            Vuelo mayor = vuelos[0];

            Vuelo temprano = vuelos[0];

            foreach (Vuelo v in vuelos)
            {
                if (v.Duracion() > mayor.Duracion())
                {
                    mayor = v;
                }

                if (v.horaSalida < temprano.horaSalida)
                {
                    temprano = v;
                }
            }
            Console.WriteLine( "Vuelo más largo: " + mayor.codigo);
            Console.WriteLine( "Vuelo más temprano: " + temprano.codigo);
            Console.ReadKey();
        }
    }
}
