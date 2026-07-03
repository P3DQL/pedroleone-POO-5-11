using System;

namespace punto3
{
    /*Actividad 3: Registro de entrenamientos
    Problema:
    Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
         Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
            1. Uno que reciba horas y minutos y los convierta a minutos.
            2. Otro que reciba directamente los minutos.
         Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
        más corto.
    */
    class Entrenamiento
    {
        public string deportista;
        public int duracion;

        public void RegistrarDuracion( int horas, int minutos)
        {
            duracion = (horas * 60) + minutos;
        }

        public void RegistrarDuracion( int minutos)
        {
            duracion = minutos;
        }
    }

    class Program
    {
        static void Main()
        {
            Entrenamiento[] e = new Entrenamiento[5];

            for (int i = 0; i < 5; i++)
            {
                e[i] = new Entrenamiento();
                Console.Write( "Deportista: ");

                e[i].deportista = Console.ReadLine();
                Console.Write( "Horas: ");

                int horas = int.Parse( Console.ReadLine());
                Console.Write( "Minutos: ");

                int minutos = int.Parse( Console.ReadLine());
                e[i].RegistrarDuracion( horas, minutos);
                Console.WriteLine();
            }
            Entrenamiento mayor = e[0];
            Entrenamiento menor = e[0];

            foreach (Entrenamiento x in e)
            {
                if (x.duracion > mayor.duracion)
                {
                    mayor = x;
                }

                if (x.duracion < menor.duracion)
                {
                    menor = x;
                }
            }
            Console.WriteLine("Más largo: " + mayor.deportista);
            Console.WriteLine("Más corto: " + menor.deportista);
            Console.ReadKey();
        }
    }
}
