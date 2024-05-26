using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClases.Class
{
    internal class ExAlumno
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public string direccion { get; set; }
        public string promocion { get; set; }

        public ExAlumno(string nombre, int id, string direccion, string promocion)
        {
            this.nombre = nombre;
            this.id = id;
            this.direccion = direccion;
            this.promocion = promocion;
        }

        public void saludar()
        {
            Console.WriteLine("Hola :)");
        }
    }
}
