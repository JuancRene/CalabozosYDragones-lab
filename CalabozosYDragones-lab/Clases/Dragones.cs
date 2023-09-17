using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Dragones : Pieza
    {
      public int DragonHumano1 { get; set; }
        public int DragonHumano2 { get; set; }

        public int DragonVirtual1 { get; set; }
        public int DragonVirtual2 { get; set; }

        public Dragones(int posicion): base(posicion) 
        { 
           DragonHumano1 = posicion;
           DragonHumano2 = posicion;
           DragonVirtual1 = posicion;
           DragonVirtual2 = posicion;
           posicion = 0;
        }

        public void PosicionInicialDH(Panel dragonHumano)
        {
           
            dragonHumano.Left = 35;
            dragonHumano.Top = 50;
        }

    }
}
