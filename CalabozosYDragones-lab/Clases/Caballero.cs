using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Caballero:Pieza 
    {
        
        public Caballero(Panel posicion): base(posicion)
        {
            Posicion = posicion;
        }

        Random Movilizar = new Random();
        public void PosicionInicialCaballero(Panel caballeros)
        {
            caballeros.Left = 35;
            caballeros.Top = 50;
            
        }

        public int Mover()
        {
            return Movilizar.Next(1,49);
        }

    }

  
}
