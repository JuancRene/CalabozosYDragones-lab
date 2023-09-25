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
        public int Calabozo1 { get; set; }
        public int Calabozo2 { get; set; }
        public int Calabozo3 { get; set; }

        public Calabozo(int posicion) 
        {
            Calabozo1 = posicion;
            Calabozo2 = posicion;
            Calabozo3 = posicion;
        }
      
    }
}
