using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructuraClases.Interfaces;

namespace EstructuraClases.Class
{
    internal class Empleado : MiembroDeLaComunidad
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public string direccion { get; set; }
        public double sueldo { get; set; }

        public Empleado(string nombre, int id, string direccion, double sueldo)
        {
            this.nombre = nombre;
            this.id = id;
            this.direccion = direccion;
            this.sueldo = sueldo;
        }

        public void saludar()
        {
            Console.WriteLine("Hola :)");
        }
    }
}
