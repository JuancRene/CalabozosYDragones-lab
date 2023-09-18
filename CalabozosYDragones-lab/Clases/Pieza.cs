using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CalabozosYDragones_lab
{
    internal class Pieza
    {
        public int Posicion { get; protected set; }

        Random posicionAzarDragones = new Random();

        public Pieza(int posicion)
        {
            Posicion = posicion;      
        }

        public int PosicionInicialCaballeros()
        {
             return Posicion = 0;
        }

        public int PosicionesAleatoriasDragones()
        {
            int posicionD;
            posicionD = posicionAzarDragones.Next(1,49);
            return posicionD;
        }



    }
}
