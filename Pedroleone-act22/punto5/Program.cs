using System;

namespace punto5
{
    /*Actividad 5: Gestión de Carreras Deportivas
    Consigna:
    Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
    una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
    Se pide:
        1. Crear una clase Carrera con:
            o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
            definidos.
            o Dos constructores (uno por defecto y otro con parámetros).
            o Método para calcular la duración de la carrera usando TimeSpan.
        2. Crear una clase Corredor con:
            o Atributos: nombre, número de dorsal y tiempo total.
            o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
            horas y minutos).

        3. Mostrar en consola (usando Console.SetCursorPosition()):
            o La carrera con mayor duración.
            o El corredor más rápido.
        4. Utilizar this en los constructores o métodos donde corresponda.
    */
    class Corredor
    {
        public string nombre;
        public int dorsal;
        public int tiempo;

        public void RegistrarTiempo( int minutos)
        {
            tiempo = minutos;
        }

        public void RegistrarTiempo( int horas, int minutos)
        {
            tiempo = (horas * 60) + minutos;
        }
    }

    class Carrera
    {
        public string codigo;
        public DateTime inicio;
        public DateTime fin;

        public Carrera()
        {
            codigo = "A1";

            inicio =  DateTime.Parse("08:00");

            fin = DateTime.Parse("10:00");
        }

        public Carrera( string codigo, DateTime inicio, DateTime fin)
        {
            this.codigo = codigo;
            this.inicio = inicio;
            this.fin = fin;
        }

        public TimeSpan Duracion()
        {
            return fin - inicio;
        }
    }

    class Program
    {
        static void Main()
        {
            Carrera[] carreras =
            {
            new Carrera( "C1", DateTime.Parse("08:00"), DateTime.Parse("11:00")),
            new Carrera( "C2", DateTime.Parse("09:00"), DateTime.Parse("10:00"))
        };

            Corredor[] corredores = new Corredor[3];

            for (int i = 0; i < 3; i++)
            {
                corredores[i] = new Corredor();

                Console.Write( "Nombre: ");

                corredores[i].nombre = Console.ReadLine();
                Console.Write( "Minutos: ");
                int minutos = int.Parse( Console.ReadLine());

                corredores[i] .RegistrarTiempo( minutos);
                Console.WriteLine();
            }

            Carrera mayor = carreras[0];

            foreach (Carrera c in carreras)
            {
                if (c.Duracion() > mayor.Duracion())
                {
                    mayor = c;
                }
            }

            Corredor rapido = corredores[0];

            foreach (Corredor c in corredores)
            {
                if (c.tiempo < rapido.tiempo)
                {
                    rapido = c;
                }
            }

            Console.Clear();
            Console.SetCursorPosition( 5, 5);
            Console.Write( "Carrera más larga: " + mayor.codigo);

            Console.SetCursorPosition(5, 8);
            Console.Write( "Más rápido: " + rapido.nombre);
            Console.ReadKey();
        }
    }
}
