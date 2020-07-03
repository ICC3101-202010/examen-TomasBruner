using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Jugador : Person
    {
        public Jugador(string nombre, string nacionalidad, string tipoJugador)
        {
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
            this.TipoJugador = tipoJugador;
        }
        public int PuntosAtaque { get; set; }
        public int PuntosDefensa { get; set; }
        public int NCamiseta { get; set; }
        public string TipoJugador { get; set; }

        public void Lesion()
        {
            Console.WriteLine("Me lesioné");
        }

        public string InfoJugador()
        {
            return "Nombre: " + Nombre + " Nacionalidad: " + Nacionalidad + " Tipo De Jugador: " + TipoJugador;
        }
    }
}
