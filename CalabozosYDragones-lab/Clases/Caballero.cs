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
       
        public int contador = 0;
        public int PosicionCaballero {get; set;}
        Caballero[] caballero = new Caballero[3];
        public string BautiLindo {get; protected set;}
        public Caballero( int posicion): base(posicion)
        {
           PosicionCaballero = posicion;
        }

        public void PosicionInicial(Panel caballeroRojo)
        {
            caballeroRojo.Left = 35;
            caballeroRojo.Top = 50;
        }

        public void PosicionInicialVirtual(Panel caballeroAzul)
        {
            caballeroAzul.Left = 35;
            caballeroAzul.Top = 50;
        }

        public void AgregarCaballero(Caballero unCaballero)
        {
            if (contador <= 3)
                caballero[contador++] = unCaballero;

        }
    }

  
}
