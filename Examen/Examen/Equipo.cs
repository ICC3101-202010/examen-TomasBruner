using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Equipo
    {
        List<Jugador> jugadores = new List<Jugador>();
        List<Equipo> equipos = new List<Equipo>();
        public Equipo()
        {

        }
        public Equipo(string nombre, string tipoEquipo, List<Jugador> jugadores, Medico Medico, Entrenador Entrenador)
        {
            this.Nombre = nombre;
            this.Jugadores = jugadores;
            this.TipoEquipo = tipoEquipo;
            this.entrenador = Entrenador;
            this.medico = Medico;
        }
        public string InfoEquipo()
        {
            return "Equipo: " + Nombre + " Medico: " + medico.Nombre + " Entrenador: " + entrenador.Nombre;
        }

        public Medico medico { get; set; }
        public Entrenador entrenador { get; set; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public List<Equipo> Equipos { get => equipos; set => value = equipos; }
        public string Nombre { get; set; }
        public string TipoEquipo { get; set; }

        public void CrearEquipoLiga()
        {
            Console.WriteLine("¿Como se llamará el equipo?");
            string nombreEquipo = Console.ReadLine();
            Console.WriteLine("¿Como se llamará el medico?");
            string nombreMedico = Console.ReadLine();
            Medico medico = new Medico(nombreMedico);
            Console.WriteLine("¿Como se llamará el entrenador?");
            string nombreEntrenador = Console.ReadLine();
            Entrenador entrenador = new Entrenador(nombreEntrenador);
            Console.WriteLine("Ahora crearemos los jugadores, empezando por los 2 arqueros");
            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("Cual será el nombre del arquero " + Convert.ToString(i + 1));
                string nombreArquero = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Cual ser la nacionalidad del arquero " + Convert.ToString(i + 1));
                string nacionalidad = Console.ReadLine();
                Console.WriteLine("");
                Jugador arquero = new Jugador(nombreArquero, nacionalidad, "Arquero");
                Jugadores.Add(arquero);
                i++;
            }
            Console.WriteLine("Ahora crearemos los jugadores");
            for (int a = 0; a < 13; ++a)
            {
                Console.WriteLine("Cual ser el nombre del jugador " + Convert.ToString(a + 1));
                string nombreJugador = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Cual ser la nacionalidad del juagdor " + Convert.ToString(a + 1));
                string nacionalidad = Console.ReadLine();
                Console.WriteLine("");
                Jugador jugador = new Jugador(nombreJugador, nacionalidad, "Jugador de cancha");
                Jugadores.Add(jugador);
            }
            Equipo equipo = new Equipo(nombreEquipo, "Liga", Jugadores, medico, entrenador);
            Equipos.Add(equipo);
        }

        public void CrearEquipoNacional()
        {
            Console.WriteLine("¿Que país será?");
            string nombreEquipo = Console.ReadLine();
            Console.WriteLine("¿Cual es el nombre de la nacionalidad de este pais?");
            string nacionalidad = Console.ReadLine();
            Console.WriteLine("¿Como se llamará el medico?");
            string nombreMedico = Console.ReadLine();
            Medico medico = new Medico(nombreMedico);
            Console.WriteLine("¿Como se llamará el entrenador?");
            string nombreEntrenador = Console.ReadLine();
            Entrenador entrenador = new Entrenador(nombreEntrenador);
            Console.WriteLine("Ahora crearemos los jugadores, empezando por los 2 arqueros");
            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("Cual será el nombre del arquero " + Convert.ToString(i + 1));
                string nombreArquero = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                Jugador arquero = new Jugador(nombreArquero, nacionalidad, "Arquero");
                Jugadores.Add(arquero);
                i++;
            }
            Console.WriteLine("Ahora crearemos los jugadores");
            for (int a = 0; a < 13; ++a)
            {
                Console.WriteLine("Cual ser el nombre del jugador " + Convert.ToString(a + 1));
                string nombreJugador = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                Jugador jugador = new Jugador(nombreJugador, nacionalidad, "Jugador de cancha");
                Jugadores.Add(jugador);
            }
            Equipo equipo = new Equipo(nombreEquipo, "Nacional", Jugadores, medico, entrenador);
            Equipos.Add(equipo);
        }

        public void VerEquipos()
        {
            int i = 0;
            foreach (Equipo equipo in Equipos)
            {
                Console.WriteLine("");
                Console.WriteLine(Convert.ToString(i + 1) + ". " + equipo.InfoEquipo());
                i++;
            }
        }

        public void VerJugadoresDeEquipo()
        {
            Console.WriteLine("¿De que equipo o pais quieres ver los jugadores? (Escribir el numero del equipo igual como en la lista)");
            int opcion = Convert.ToInt32(Console.ReadLine());
            foreach (Jugador jugador in Equipos[opcion - 1].Jugadores)
            {
                Console.WriteLine(jugador.InfoJugador());
            }
        }
    }
}
