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
        public int DragonH1 { get; set; }
        public int DragonH2 { get; set; }
        public int DragonV1 { get; set; }
        public int DragonV2 { get; set; }
        public int DragonV3 { get; set; }
        public int DragonV4 { get; set; }
        public int DragonV5 { get; set; }
        public int DragonV6 { get; set; }

        public Dragones(int posicion): base(posicion) 
        { 
           DragonH1 = posicion;
           DragonH2 = posicion;
           DragonV1 = posicion;
           DragonV2 = posicion;
           DragonV3 = posicion;
           DragonV4 = posicion;
           DragonV5 = posicion;
           DragonV6 = posicion;
 
        }

        public void PosicionInicialDH1(Panel dragonH1)
        {
            DragonH1 = base.PosicionesAleatoriasDragones(); 
            dragonH1.Left = 35;
            dragonH1.Top = 50;
        }

        public void PosicionInicialDH2(Panel dragonH2)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonH2.Left = 35;
            dragonH2.Top = 50;
        }

        public void PosicionInicialDV1(Panel dragonV1)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV1.Left = 35;
            dragonV1.Top = 50;
        }

        public void PosicionInicialDV2(Panel dragonV2)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV2.Left = 35;
            dragonV2.Top = 50;
        }

        public void PosicionInicialDV3(Panel dragonV3)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV3.Left = 35;
            dragonV3.Top = 50;
        }

        public void PosicionInicialDV4(Panel dragonV4)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV4.Left = 35;
            dragonV4.Top = 50;
        }

        public void PosicionInicialDV5(Panel dragonV5)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV5.Left = 35;
            dragonV5.Top = 50;
        }

        public void PosicionInicialDV6(Panel dragonV6)
        {
            DragonH2 = base.PosicionesAleatoriasDragones();
            dragonV6.Left = 35;
            dragonV6.Top = 50;
        }

    }
}
