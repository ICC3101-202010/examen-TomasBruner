using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Entrenador : Person
    {
        public Entrenador(string nombre)
        {
            this.Nombre = nombre;
            
        }
        public int PuntosTactica { get; set; }
        
    }
}
