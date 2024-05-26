using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructuraClases.Interfaces;

namespace EstructuraClases.Class
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public string direccion { get; set; }
        public int cantidadMaterias { get; set; }

        public Estudiante(string nombre, int id, string direccion, int cantidadMaterias)
        {
            this.nombre = nombre;
            this.id = id;
            this.direccion = direccion;
            this.cantidadMaterias = cantidadMaterias;
        }

        public void saludar()
        {
            Console.WriteLine("Hola :)");
        }
    }
}
