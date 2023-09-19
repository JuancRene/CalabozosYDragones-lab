using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalabozosYDragones_lab.Clases;
using System.ComponentModel.Design;

namespace CalabozosYDragones_lab
{
    public partial class Form1:Form
    {
        #region Instanciacion de clases/Ventanas
        Sistema sistema = new Sistema();
        Intermedio intermedio = new Intermedio(0);
        WinnerRosa winnerRosa = new WinnerRosa();
        WinnerAzul winnerAzul = new WinnerAzul();
        WinnerVerde winnerVerde = new WinnerVerde();
        WinnerAmarillo winnerAmarillo = new WinnerAmarillo();
        Caballero caballero = new Caballero(0);
        #endregion

        #region Declaracion de variables
        int a = 0, c, f;
        int posicionA = 0, posicionB = 0, posicionC = 0, posicionD = 0;
        int jugador = 0;
        int posicionDragon = 0;
        int columnaMaquina = 0;
        int filaMaquina = 0;
        int posiciondragon2 = 0;
        int columnaDragon2 = 0;
        int filaDragon2 = 0;
        int columnaDragon1 = 0;
        int filaDragon1 = 0;
        int DragonHumano = 0;
        int DragonHumano2 = 0;
        bool mostarLista = false;
        int columnaMaquina2 = 0;
        int filaMaquina2 = 0;
        int columnaMaquina3 = 0;
        int filaMaquina3 = 0;
        int DragonMaquina = 0;
        int DragonMaquina2 = 0;
        int DragonMaquina3 = 0;
        int DragonMaquina4 = 0;
        int DragonMaquinaa3 = 0;
        int DragonMaquinaa4 = 0;
        

        #endregion


        public Form1()
        {
            InitializeComponent();
            Iniciar();
            
        }

        private void BtnHumano_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                #region Dragon1
                DragonHumano = sistema.MoverDragonHumano();
                sistema.ColumnaDragon1 = (DragonHumano % 10) * 90;
                sistema.FilaDragon1 = (DragonHumano / 10) * 90;

                #endregion

                #region Dragon2

                DragonHumano2 = sistema.MoverDragonHumano2();
                sistema.ColumnaDragon2 = (DragonHumano2 % 10) * 90;
                sistema.FilaDragon2 = (DragonHumano2 / 10) * 90;

                DragoncitoHumano1.Visible = true;
                DragoncitoHumano2.Visible = true;

                #endregion
            }

            dadoA.Visible = false;
            jugador = 1;
            pBdado.Visible = true;
            timer1.Stop();
            timer1.Start();
            posicionA += sistema.MoverHumano();
            c = (posicionA % 10) * 90;
            f = (posicionA / 10) * 90;
            dadoA.Text = sistema.NumeroRandom3.ToString();
         
            if (posicionA == DragonHumano)
            {
                intermedio.AvanceDragon1();
                Refresh();
            }

            else if (posicionA == DragonHumano2)
            {
                intermedio.AvanceDragon2();
                Refresh();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBdado.Visible = false;
            dadoA.Visible = true;
        }

        private void Iniciar()
        {
            caballero.PosicionInicialH(CaballeroRosa);
            caballero.PosicionInicialV1(CaballeroAzul);
            caballero.PosicionInicialV2(CaballeroAmarillo);
            caballero.PosicionInicialV2(CaballeroVerde);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //PantallaCarga pantallaCarga = new PantallaCarga(6);
            //pantallaCarga.ShowDialog();

            #region Desvisualizacion de botones
            BtnHumano.Enabled = false;
            BtnMaquina.Enabled = false;
            Calabozo1.Visible = false;
            Calabozo2.Visible = false;
            Calabozo3.Visible = false;
            DragoncitoHumano1.Visible = false;
            DragoncitoHumano2.Visible = false;
            CaballeroAmarillo.Visible = false;
            CaballeroAzul.Visible = false;
            CaballeroRosa.Visible = false;
            CaballeroVerde.Visible = false;
            BtnMaquina.Visible = false;
            BtnMaquina2.Visible = false;
            BtnMaquina3.Visible = false;
            DragonAzul1.Visible = false;
            DragonAzul2.Visible = false;
            DragonAmarillo1.Visible = false;
            DragonAmarillo2.Visible = false;
            DragoncitoHumano1.Visible = false;
            DragoncitoHumano2.Visible = false;
            DragonVerde1.Visible = false;
            DragonVerde2.Visible = false;
            #endregion

        }

        private void dragoncito_Tick(object sender, EventArgs e)
        {
            
        }

        private void BtnMaquina_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                #region DragonMaquina
                DragonMaquina = sistema.MoverDragonMaquina();
                sistema.ColumnaDragonMaquina1 = (DragonMaquina % 10) * 90;
                sistema.FilaDragonMaquina1 = (DragonMaquina / 10) * 90;

                #endregion

                #region DragonMaquina2

                DragonMaquina2 = sistema.MoverDragonMaquina2();
                sistema.ColumnaDragonMaquina2 = (DragonMaquina2 % 10) * 90;
                sistema.FilaDragonMaquina2 = (DragonMaquina2 / 10) * 90;

                DragonAzul1.Visible = true;
                DragonAzul2.Visible = true;

                #endregion
            }

            dadoA.Visible = false;
            jugador = 2;
            pBdado.Visible = true;         
            timer1.Stop();
            timer1.Start();
            posicionB += sistema.MoverMaquina();
            columnaMaquina = (posicionB % 10) * 90;
            filaMaquina = (posicionB / 10) * 90;
            dadoA.Text = sistema.NumeroRandom1.ToString();

            //if (posicionB == posicionDragon)
            //{
            //    posicionB -= 5;
            //    columnaMaquina = (posicionB % 10) * 90;
            //    filaMaquina = (posicionB / 10) * 90;
            //    MessageBox.Show("Retrocede 5 lugares");
            //}
            //if (posicionB == posiciondragon2)
            //{
            //    posicionB -= 5;
            //    columnaMaquina = (posicionB % 10) * 90;
            //    filaMaquina = (posicionB / 10) * 90;
            //    MessageBox.Show("Retrocede 5 lugares");

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameOver FinDelJuego = new GameOver(3);
            FinDelJuego.ShowDialog();
            
        }
        
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DragoncitoHumano2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DragoncitoHumano1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaVirtual_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void CaballeroAzul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CaballeroRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                decimal NroDeJugadores;
                NroDeJugadores = numericUpDown1.Value;

                if (NroDeJugadores == 1)
                {
                    CaballeroAzul.Visible = true;
                    BtnMaquina.Visible = true;
                }
                if (NroDeJugadores == 2)
                {
                    CaballeroAmarillo.Visible = true;
                    CaballeroAzul.Visible = true;
                    BtnMaquina2.Visible = true;
                    BtnMaquina.Visible = true;

                }
                if (NroDeJugadores == 3)
                {
                    
                    CaballeroAzul.Visible = true;
                    CaballeroVerde.Visible = true;
                    CaballeroAmarillo.Visible = true;
                    CaballeroVerde.Visible = true;
                    BtnMaquina2.Visible = true;
                    BtnMaquina.Visible = true;
                    BtnMaquina3.Visible = true;

                }
                numericUpDown1.Enabled = false;

                BtnHumano.Enabled = true;
                BtnMaquina.Enabled = true;
                TxtNombre.Enabled = false;

            }
            else
            {
                MessageBox.Show("ELIJA UN NIVEL","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
            

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             
            
        }

        private void BtnMaquina2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                #region DragonMaquina3
                DragonMaquina3 = sistema.MoverDragonMaquina3();
                sistema.ColumnaDragonMaquina3 = (DragonMaquina3 % 10) * 90;
                sistema.FilaDragonMaquina3 = (DragonMaquina3 / 10) * 90;

                #endregion

                #region DragonMaquina3

                DragonMaquinaa3 = sistema.MoverDragonMaquinaa3();
                sistema.ColumnaDragonMaquinaa3 = (DragonMaquinaa3 % 10) * 90;
                sistema.FilaDragonMaquinaa3 = (DragonMaquinaa3 / 10) * 90;

                DragonAmarillo1.Visible = true;
                DragonAmarillo2.Visible = true;

                #endregion
            }

            dadoA.Visible = false;
            jugador = 3;
            pBdado.Visible = true;
            timer1.Stop();
            timer1.Start();
            posicionC += sistema.MoverMaquina2();
            columnaMaquina2 = (posicionC % 10) * 90;
            filaMaquina2 = (posicionC / 10) * 90;
            dadoA.Text = sistema.NumeroRandom4.ToString();

        }

        private void BtnMaquina3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                #region DragonMaquina3
                DragonMaquina4 = sistema.MoverDragonMaquina4();
                sistema.ColumnaDragonMaquina4 = (DragonMaquina4 % 10) * 90;
                sistema.FilaDragonMaquina4 = (DragonMaquina4 / 10) * 90;

                #endregion

                #region DragonMaquina3

                DragonMaquinaa4 = sistema.MoverDragonMaquinaa4();
                sistema.ColumnaDragonMaquinaa4 = (DragonMaquinaa4 % 10) * 90;
                sistema.FilaDragonMaquinaa4 = (DragonMaquinaa4 / 10) * 90;

                DragonVerde1.Visible = true;
                DragonVerde2.Visible = true;

                #endregion
            }

            dadoA.Visible = false;
            jugador = 4;
            pBdado.Visible = true;
            timer1.Stop();
            timer1.Start();
            posicionD += sistema.MoverMaquina3();
            columnaMaquina3 = (posicionD % 10) * 90;
            filaMaquina3 = (posicionD / 10) * 90;
            dadoA.Text = sistema.NumeroRandom5.ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                CaballeroRosa.Visible = true;
                comboBox1.Enabled = false;

            }
            
            if (comboBox1.SelectedIndex == 1)
            {
                CaballeroRosa.Visible = true;
                
                comboBox1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
                Calabozo1.Visible = true;
                Calabozo2.Visible = true;
                Calabozo3.Visible = true;

            }
            else 
            {
               
                DragoncitoHumano1.Visible = false;
                DragoncitoHumano2.Visible = false;
                
                
            }
            
        }

        private void dadoA_VisibleChanged(object sender, EventArgs e)
        {
            switch (jugador)
            {
                case 1:
                    {

                        DragoncitoHumano2.Left = 55 + sistema.ColumnaDragon2;
                        DragoncitoHumano2.Top = 65 + sistema.FilaDragon2;
                        DragoncitoHumano1.Left = 55 + sistema.ColumnaDragon1;
                        DragoncitoHumano1.Top = 65 + sistema.FilaDragon1;
                        CaballeroRosa.Left = 55 + c;
                        CaballeroRosa.Top = 65 + f;
                        
                        if (posicionA >= 49)
                        {
                            TxtNombre.Enabled = true;
                            numericUpDown1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox1.SelectedItem = null;
                            BtnMaquina.Visible = false;
                            BtnMaquina2.Visible = false;
                            BtnMaquina3.Visible = false;
                            BtnHumano.Enabled = false;
                            CaballeroVerde.Visible = false;
                            CaballeroRosa.Visible = false;
                            CaballeroAzul.Visible = false;
                            CaballeroAmarillo.Visible = false;
                            winnerRosa.NombreGanador.Text = TxtNombre.Text;
                            CaballeroRosa.Left = 15 + 300;
                            CaballeroRosa.Top = 5 + 300;
                            winnerRosa.ShowDialog();
                            c = 0;
                            f = 0;
                            posicionA = 0;
                            Iniciar();
                           
                        }

                    }
                    break;
                case 2:
                    {
                        DragonAzul2.Left = 55 + sistema.ColumnaDragonMaquina2;
                        DragonAzul2.Top = 65 + sistema.FilaDragonMaquina2;
                        DragonAzul1.Left = 55 + sistema.ColumnaDragonMaquina1;
                        DragonAzul1.Top = 65 + sistema.FilaDragonMaquina1;
                        CaballeroAzul.Left = 55 + columnaMaquina;
                        CaballeroAzul.Top = 65 + filaMaquina;
                        
                        if (posicionB >= 49)
                        {
                            TxtNombre.Enabled = true;
                            numericUpDown1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox1.SelectedItem = null;
                            BtnMaquina.Visible = false;
                            BtnMaquina2.Visible = false;
                            BtnMaquina3.Visible = false;
                            BtnHumano.Enabled = false;
                            CaballeroVerde.Visible = false;
                            CaballeroAmarillo.Visible = false;
                            CaballeroRosa.Visible = false;
                            CaballeroAzul.Visible = false;
                            CaballeroAzul.Left = 15 + 300;
                            CaballeroAzul.Top = 38 + 300;
                            winnerAzul.ShowDialog();
                            columnaMaquina = 0;
                            filaMaquina = 0;
                            posicionB = 0;
                            Iniciar();
                            
                        }
                        break;
                    }

                case 3:
                    {

                        DragonAmarillo2.Left = 55 + sistema.ColumnaDragonMaquinaa3;
                        DragonAmarillo2.Top = 65 + sistema.FilaDragonMaquinaa3;
                        DragonAmarillo1.Left = 55 + sistema.ColumnaDragonMaquina3;
                        DragonAmarillo1.Top = 65 + sistema.FilaDragonMaquina3;
                        CaballeroAmarillo.Left = 55 + columnaMaquina2;
                        CaballeroAmarillo.Top = 65 + filaMaquina2;

                        if (posicionC >= 49)
                        {
                            TxtNombre.Enabled = true;
                            numericUpDown1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox1.SelectedItem = null;
                            BtnMaquina.Visible = false;
                            BtnMaquina2.Visible = false;
                            BtnMaquina3.Visible = false;
                            BtnHumano.Enabled = false;
                            CaballeroAmarillo.Visible = false;
                            CaballeroAzul.Visible = false;
                            CaballeroRosa.Visible = false;
                            CaballeroVerde.Visible = false;
                            CaballeroAmarillo.Left = 15 + 300;
                            CaballeroAmarillo.Top = 5 + 300;
                            winnerAmarillo.ShowDialog();
                            columnaMaquina2 = 0;
                            filaMaquina2 = 0;
                            posicionC = 0;
                            Iniciar();
                        }

                    }
                    break;
                case 4:
                    {

                        DragonVerde2.Left = 55 + sistema.ColumnaDragonMaquinaa4;
                        DragonVerde2.Top = 65 + sistema.FilaDragonMaquinaa4;
                        DragonVerde1.Left = 55 + sistema.ColumnaDragonMaquina4;
                        DragonVerde1.Top = 65 + sistema.FilaDragonMaquina4;
                        CaballeroVerde.Left = 55 + columnaMaquina3;
                        CaballeroVerde.Top = 65 + filaMaquina3;

                        if (posicionD >= 49)
                        {
                            TxtNombre.Enabled = true;
                            numericUpDown1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox1.SelectedItem = null;
                            BtnMaquina.Visible = false;
                            BtnMaquina2.Visible = false;
                            BtnMaquina3.Visible = false;
                            BtnHumano.Enabled = false;
                            CaballeroAzul.Visible = false;
                            CaballeroRosa.Visible = false;
                            CaballeroAmarillo.Visible = false;
                            CaballeroVerde.Visible = false;
                            CaballeroVerde.Left = 15 + 300;
                            CaballeroVerde.Top = 5 + 300;
                            winnerVerde.ShowDialog();
                            columnaMaquina3 = 0;
                            filaMaquina3 = 0;
                            posicionD = 0;
                            Iniciar();
                        }

                    }
                    break;
            }

        }

    }
}
