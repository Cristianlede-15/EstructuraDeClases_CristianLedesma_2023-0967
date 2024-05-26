using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClases.Class.SubClases
{
    internal class Docente : Empleado
    {
        public Docente(string nombre, int id, string direccion, double sueldo) : base(nombre, id, direccion, sueldo)
        {
        }
    }
}
