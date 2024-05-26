using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClases.Class.SubClases
{
    internal class Administrativo : Empleado
    {
        public Administrativo(string nombre, int id, string direccion, double sueldo) : base(nombre, id, direccion, sueldo)
        {
        }
    }
}
