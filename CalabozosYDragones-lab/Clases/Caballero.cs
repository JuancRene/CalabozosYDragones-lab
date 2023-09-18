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
        public int AvanceCaballeroH { get; set; } 
         public int AvanceCaballeroV1 { get; set; }
        public int AvanceCaballeroV2 { get; set; }
        public int AvanceCaballeroV3 { get; set; }
        //Caballero[] caballero = new Caballero[3];

        public Caballero( int posicion): base(posicion)
        {
            AvanceCaballeroH = posicion;
            AvanceCaballeroV1 = posicion;
            AvanceCaballeroV2 = posicion;
            AvanceCaballeroV3 = posicion;
        }

        public int PosicionInicialH(Panel caballeroRosado)
        {
            AvanceCaballeroH = base.PosicionInicialCaballeros();
            caballeroRosado.Left = 35;
            caballeroRosado.Top = 50;
            return AvanceCaballeroH;
        }
        public void PosicionInicialV1(Panel caballeroAzul)
        {
            AvanceCaballeroV1 = base.PosicionInicialCaballeros();
            caballeroAzul.Left = 35;
            caballeroAzul.Top = 50;
        }

        public void PosicionInicialV2(Panel caballeroAmarillo)
        {
            AvanceCaballeroV2 = base.PosicionInicialCaballeros();
            caballeroAmarillo.Left = 35;
            caballeroAmarillo.Top = 50;
        }

        public void PosicionInicialV3(Panel caballeroVerde)
        {
            AvanceCaballeroV3 = base.PosicionInicialCaballeros();
            caballeroVerde.Left = 35;
            caballeroVerde.Top = 50;
        }

        //public void PosicionInicialVirtual1(Panel caballeroAzul)
        //{
        //    AvanceCaballeroV1 = base.PosicionesAleatoriasDragones();
        //    caballeroAzul.Left = 35;
        //    caballeroAzul.Top = 50;
        //}

        //public void AgregarCaballero(Caballero unCaballero)
        //{
        //    if (contador <= 3)
        //        caballero[contador++] = unCaballero;

        //}
    }

  
}
