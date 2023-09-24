using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab.Clases
{
    internal class Intermedio:Basico
    {
        Dragones dragones = new Dragones(0);
        
       
        int posicionA = 0;
        int posicionB = 0;
        int c, f, columnaMaquina, filaMaquina;

        public Intermedio( int posicion) : base(posicion)
        {
            
           
        }

        public int AvanceDragon1()
        {
                posicionA = base.Posicion;
                posicionA += 5;
                c = (posicionA % 10) * 90;
                f = (posicionA / 10) * 90;
                MessageBox.Show("Aumenta 5 lugares");
                return posicionA;
                
              
        }
        public int AvanceDragon2()
        {

            posicionA = base.Posicion;
            posicionA += 5;
            c = (posicionA % 10) * 90;
            f = (posicionA / 10) * 90;
            MessageBox.Show("Aumenta 5 lugares");
            return posicionA;


        }

    }
}
