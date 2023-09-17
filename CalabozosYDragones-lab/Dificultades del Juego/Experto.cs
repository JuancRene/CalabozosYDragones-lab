using CalabozosYDragones_lab.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalabozosYDragones_lab
{
    internal class Experto
    {
        
        Random r = new Random();
        int posicion = r.Next(0, 59);
        Experto()
        {
            Calabozo calbozo = new Calabozo(posicion);
        }
      
    }
}
