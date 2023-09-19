using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Linq.Expressions;

namespace CalabozosYDragones_lab
{
    internal class Sistema
    {
        ArrayList jugador = new ArrayList(); 
        Jugador Humano { get; set; }
        static Random Dragon = new Random();
        static Random Dragon2 = new Random();


        int dragonHumano = 0;
        int posicionDragon1 = 0;
        int columnaDragon1 = 0;
        int filaDragon1 = 0;
        int columnaDragon2 = 0;
        int filaDragon2 = 0;
        int posicionDragon2=0;
        int dragonHumano2 = 0;

        public int PosicionDragon1 { get { return posicionDragon1; } set { value = posicionDragon1; }}
        public int PosicionDragon2 { get { return posicionDragon2;} set { value = posicionDragon2; } }
        public int ColumnaDragon1 { get ; set; }
        public int FilaDragon1 { get; set; }
        public int NumeroRandom1 { get; set; }
        public int NumeroRandom2 { get; set; }
        public int NumeroRandom3 { get; set; }
        public int ColumnaDragon2 { get; set; }
        public int FilaDragon2 { get; set; }
        public int NumeroRandom4 { get; set; }
        public int NumeroRandom5 { get; set; }
        public int NumeroRandom6 { get; set; }
        public int NumeroRandom7 { get; set; }
        public int NumeroRandom8 { get; set; }
        public int NumeroRandom9 { get; set; }
        public int NumeroRandom10 { get; set; }
        public int ColumnaDragonMaquina1 { get; set; }
        public int FilaDragonMaquina1 { get; set; }
        public int ColumnaDragonMaquina2 { get; set; }
        public int FilaDragonMaquina2 { get; set; }
        public int ColumnaDragonMaquina3 { get; set; }
        public int FilaDragonMaquina3 { get; set; }
        public int ColumnaDragonMaquinaa3 { get; set; }
        public int FilaDragonMaquinaa3 { get; set; }
        public int ColumnaDragonMaquina4 { get; set; }
        public int FilaDragonMaquina4 { get; set; }
        public int ColumnaDragonMaquinaa4 { get; set; }
        public int FilaDragonMaquinaa4 { get; set; }



        Random NumeroAleatorio = new Random();
        Random NumeroRandomMaquina = new Random();
        Random RandomMaquinaTres = new Random();
        string Nombre { get; set; }

        Jugador j;
        public Sistema()
        {
            Jugador jugadorHumano = new Jugador(Nombre);
            Jugador Maquina1 = new Jugador("Maquina1");
            Jugador Maquina2 = new Jugador("Maquina2");
            Jugador Maquina3 = new Jugador("Maquina3");

        }

        public void AgregarJugador(Jugador nuevoJugador)
        {
            jugador.Add(nuevoJugador);  
        }

        public int MoverHumano()
        {
            
            Random Posicion = new Random();
            NumeroRandom3 = Posicion.Next(1, 6);
            return NumeroRandom3;
        }

        public int MoverMaquina()
        {
            Random Posicion = new Random();
            NumeroRandom1 = Posicion.Next(1, 6);
            return NumeroRandom1;
        }
        public int MoverMaquina2()
        {
            Random Mover = new Random();
            NumeroRandom4 = Mover.Next(1, 6);
            return NumeroRandom4;
        }
        public int MoverMaquina3()
        {
            Random MoverMaquina3 = new Random();
            NumeroRandom5 = MoverMaquina3.Next(1, 6);
            return NumeroRandom5;
        }

        public int MoverDragonHumano()
        {

            posicionDragon1 = Dragon.Next(1, 49);
            return posicionDragon1;

        }

        public int MoverDragonHumano2()
        {
            Random NumeroAleatorio = new Random();
            NumeroRandom2 = NumeroAleatorio.Next(1, 49);
            return NumeroRandom2;
        }

        public int MoverDragonMaquina()
        {
           
            NumeroRandom6 = NumeroRandomMaquina.Next(1, 49);
            return NumeroRandom6;
                
        }
        public int MoverDragonMaquina2()
        {

            Random NumeroAleatorio2 = new Random();
            NumeroRandom7 = NumeroAleatorio2.Next(1, 49);
            return NumeroRandom7;

        }
        public int MoverDragonMaquina3()
        {

            Random RandomMaquina3 = new Random();
            NumeroRandom8 = RandomMaquina3.Next(1, 49);
            return NumeroRandom8;

        }
        public int MoverDragonMaquinaa3()
        {

            NumeroRandom8 = RandomMaquinaTres.Next(1, 49);
            return NumeroRandom8;

        }
        public int MoverDragonMaquinaa4()
        {

            NumeroRandom9 = RandomMaquinaTres.Next(1, 49);
            return NumeroRandom9;

        }
        public int MoverDragonMaquina4()
        {

            Random MoverMaquina = new Random();
            NumeroRandom10 = MoverMaquina.Next(1, 49);
            return NumeroRandom10;

        }





    }
}
