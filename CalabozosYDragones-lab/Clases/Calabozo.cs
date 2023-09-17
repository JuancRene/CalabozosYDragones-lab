using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalabozosYDragones_lab.Clases
{
    internal class Calabozo
    {

        public Random AgregarCalabozo(Random Posicion)
        {
            Posicion.Next(0,49);
            return Posicion;
        }
    }
}
