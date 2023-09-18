using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CalabozosYDragones_lab.Clases;
using System.ComponentModel.Design;

namespace CalabozosYDragones_lab
{
    public partial class Form1:Form
    {

        Random dragon1 = new Random();
        Random dragon2 = new Random();
        Random dado = new Random();
        GameOver game = new GameOver();
        Sistema sistema = new Sistema();
        Intermedio intermedio = new Intermedio(0);
        WinnerRosa winnerRosa = new WinnerRosa();
        WinnerAzul winnerAzul = new WinnerAzul();
        WinnerVerde winnerVerde = new WinnerVerde();
        WinnerAmarillo winnerAmarillo = new WinnerAmarillo();
        Caballero caballero = new Caballero(0);
        Dragones dragones = new Dragones(0);
        
        int a = 0, c, f;
        int posicionA = 0, posicionB = 0, posicionC = 0, posicionD = 0;
        int jugador = 0;
        int posicionDragon = 0;
        int columnaMaquina = 0;
        int filaMaquina = 0;
        int posiciondragon2=0;
        int  columnaDragon2 =0;
        int filaDragon2 =0;
        int columnaDragon1 =0;
        int filaDragon1 =0;
        int DragonHumano = 0;
        int DragonHumano2 = 0;
        bool mostarLista = false;
        int columnaMaquina2 = 0;
        int filaMaquina2 = 0;
        int columnaMaquina3 = 0;
        int filaMaquina3 = 0;

        public Form1()
        {
            InitializeComponent();
            Sistema sis =  new Sistema();
            Iniciar();
            //SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = "C:/Users/Administrator/Desktop/Musica/AgeOfEmpire.wav";
            //soundPlayer.Play();

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
            


            //posicionA = intermedio.RetrocesoDragon1();

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
            caballero.PosicionInicial(CaballeroRosa);
            caballero.PosicionInicialVirtual1(CaballeroAzul);
            caballero.PosicionInicialVirtual2(CaballeroAmarillo);
            caballero.PosicionInicialVirtual3(CaballeroVerde);

            //dragones.PosicionInicialDH(DragoncitoHumano1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //PantallaCarga pantallaCarga = new PantallaCarga(6);
            //pantallaCarga.ShowDialog();

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
            
        }

        private void dragoncito_Tick(object sender, EventArgs e)
        {
            
        }

        private void BtnMaquina_Click(object sender, EventArgs e)
        {
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

                BtnHumano.Enabled = true;
                BtnMaquina.Enabled = true;

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
                DragoncitoHumano1.Visible = true;
                DragoncitoHumano2.Visible = true;
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
                        CaballeroAzul.Left = 55 + columnaMaquina;
                        CaballeroAzul.Top = 65 + filaMaquina;
                        dadoR.Text = a.ToString();
                        if (posicionB >= 49)
                        {
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

                        //DragoncitoHumano2.Left = 55 + sistema.ColumnaDragon2;
                        //DragoncitoHumano2.Top = 65 + sistema.FilaDragon2;
                        //DragoncitoHumano1.Left = 55 + sistema.ColumnaDragon1;
                        //DragoncitoHumano1.Top = 65 + sistema.FilaDragon1;
                        CaballeroAmarillo.Left = 55 + columnaMaquina2;
                        CaballeroAmarillo.Top = 65 + filaMaquina2;

                        if (posicionC >= 49)
                        {
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

                        //DragoncitoHumano2.Left = 55 + sistema.ColumnaDragon2;
                        //DragoncitoHumano2.Top = 65 + sistema.FilaDragon2;
                        //DragoncitoHumano1.Left = 55 + sistema.ColumnaDragon1;
                        //DragoncitoHumano1.Top = 65 + sistema.FilaDragon1;
                        CaballeroVerde.Left = 55 + columnaMaquina3;
                        CaballeroVerde.Top = 65 + filaMaquina3;

                        if (posicionD >= 49)
                        {
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
