using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Basico
    {
       Random dado = new Random();
        Caballero caballero = new Caballero(0);
       public int Posicion { get; set; }
        public Basico(int posicion)
        {
            Posicion = posicion;

        }

        public int MoverCaballeroHumano()
        {
            int posicionC = dado.Next(1, 6);
            return posicionC;
        }

        public int MoverCaballerosVirtuales()
        {

            int posicionV = dado.Next(1, 6);
            return posicionV;

        }



    }
}
