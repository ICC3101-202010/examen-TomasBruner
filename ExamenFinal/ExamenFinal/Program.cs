using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo();
            List<Equipo> equipos = new List<Equipo>();
            Console.WriteLine("Bienvenido, ¿que deseas hacer?");
            Console.WriteLine("1. Crear Equipo");
            Console.WriteLine("2. Ver Equipos");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion == 1 || opcion == 2 || opcion == 3)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Para empezar, ¿que tipo de equipo quieres crear?");
                    Console.WriteLine("1. Seleccion Nacional");
                    Console.WriteLine("2. Equipo de Liga");
                    int tipoDeEquipo = Convert.ToInt32(Console.ReadLine());
                    if (tipoDeEquipo == 1)
                    {
                        equipo.CrearEquipoNacional();
                    }
                    if (tipoDeEquipo == 2)
                    {
                        equipo.CrearEquipoLiga();
                    }
                }
                if (opcion == 2)
                { 
                    Console.WriteLine("Aqui están los equipos");
                    Console.WriteLine("");
                    equipo.VerEquipos();
                    Console.WriteLine("¿Que desea hacer?");
                    Console.WriteLine("1. Ver Jugadores de un equipo");
                    Console.WriteLine("2. Volver");
                    int opcion1 = Convert.ToInt32(Console.ReadLine());
                    while (opcion1 == 1 || opcion1 == 2)
                    {
                        if (opcion1 == 1)
                        {
                            equipo.VerJugadoresDeEquipo();
                        }
                        if (opcion1 == 2)
                        {
                            break;
                        }
                        Console.WriteLine("1. Ver Jugadores de un equipo");
                        Console.WriteLine("2. Volver");
                        opcion1 = Convert.ToInt32(Console.ReadLine());
                    }

                }
                if (opcion == 3)
                {
                    Console.WriteLine("Adios");
                    break;
                }
                Console.WriteLine("1. Crear Equipo");
                Console.WriteLine("2. Ver Equipos");
                Console.WriteLine("3. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

            }



            Console.ReadKey();
        }
    }
}
