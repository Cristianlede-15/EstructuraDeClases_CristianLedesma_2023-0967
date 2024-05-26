using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClases.Class.SubClases
{
    internal class Administrador : Docente
    {
        public Administrador(string nombre, int id, string direccion, double sueldo) : base(nombre, id, direccion, sueldo)
        {
        }
    }
}
