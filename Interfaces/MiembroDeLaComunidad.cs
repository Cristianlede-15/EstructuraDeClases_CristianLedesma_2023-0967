using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClases.Interfaces
{
    internal interface MiembroDeLaComunidad
    {
        string nombre { get; set; }
        int id { get; set; }
        string direccion { get; set; }


        public void saludar()
        {
            Console.WriteLine("Hola :)");
        }
    }
}
