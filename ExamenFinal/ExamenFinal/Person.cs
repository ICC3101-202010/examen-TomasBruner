using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public abstract class Person
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public int Sueldo { get; set; }
    }
}