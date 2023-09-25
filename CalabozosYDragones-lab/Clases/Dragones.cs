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
        

        public Dragones(Panel posicion): base(posicion) 
        { 
           base.Posicion = posicion;
           
        }

        public void PosicionInicialDragones(Panel dragonH1)
        {
            
            dragonH1.Left = 35;
            dragonH1.Top = 50;
        }

    }
}
