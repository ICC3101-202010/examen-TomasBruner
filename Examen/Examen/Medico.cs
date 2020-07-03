using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Medico : Person
    {
        public Medico(string nombre)
        {
            this.Nombre = nombre;

        }
        public int PuntosExp { get; set; }
    }
}
