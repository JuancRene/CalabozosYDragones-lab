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
        

        static Random random = new Random();
        int posicion = random.Next(0, 59);

        public Experto()
        {
            Calabozo calbozo = new Calabozo(posicion);
        }
      
    }
}
