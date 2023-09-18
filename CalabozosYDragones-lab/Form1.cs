﻿using System;
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
    public partial class Form1 : Form
    {
        Random dragon1 = new Random();
        Random dragon2 = new Random();
        Random dado = new Random();
        GameOver game = new GameOver();
        Sistema sistema = new Sistema();
        Intermedio intermedio = new Intermedio(0);
        
        Caballero caballero = new Caballero(0);
        Dragones dragones = new Dragones(0);
        int a = 0, c, f;
        int posicionA = 0, posicionB = 0;
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
            #region Dragon1
            dragones.PosicionInicialDH1(DragoncitoHumano1);
            sistema.ColumnaDragon1 = (DragonHumano % 10) * 90;
            sistema.FilaDragon1 = (DragonHumano / 10) * 90;



            #endregion

            #region Dragon2

            dragones.PosicionInicialDH2(DragoncitoHumano2);
            sistema.ColumnaDragon2 = (DragonHumano2 % 10) * 90;
            sistema.FilaDragon2 = (DragonHumano2 / 10) * 90;

            DragoncitoHumano1.Visible = true;
            DragoncitoHumano2.Visible = true;


            #endregion


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
            caballero.PosicionInicialH(CaballeroRosado);
            caballero.PosicionInicialV1(CaballeroAzul);
            
            //dragones.PosicionInicialDH(DragoncitoHumano1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHumano.Enabled = false;
            BtnMaquina.Enabled = false;
            Calabozo1.Visible = false;
            Calabozo2.Visible = false;
            Calabozo3.Visible = false;
            DragoncitoHumano1.Visible = false;
            DragoncitoHumano2.Visible = false;
            CaballeroAmarillo.Visible = false;
            CaballeroAzul.Visible = false;
            CaballeroRojo.Visible = false;
            CaballeroVerde.Visible = false;

            
            //PantallaCarga pantallaCarga = new PantallaCarga(6);
            //pantallaCarga.ShowDialog();
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
            decimal NroDeJugadores;
            NroDeJugadores = numericUpDown1.Value;

            if(NroDeJugadores == 1)
            {
                CaballeroAzul.Visible = true;
            }
            if(NroDeJugadores == 2)
            {

            }

            BtnHumano.Enabled = true;
            BtnMaquina.Enabled = true;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                CaballeroRojo.Visible = true;
                comboBox1.Enabled = false;
            }
            
                if (comboBox1.SelectedIndex == 1)
            {
                dragones.PosicionInicialDH1(DragoncitoHumano1);
                dragones.PosicionInicialDH2(DragoncitoHumano1);
                //DragoncitoHumano1.Left = 35;
                //DragoncitoHumano1.Top = 50;
                //DragoncitoHumano2.Left = 35;
                //DragoncitoHumano2.Top = 50;
                //DragoncitoHumano1.Visible = true;
                //DragoncitoHumano2.Visible = true;



                //string seleccionarItem = comboBox1.SelectedIndex.ToString();
                //MessageBox.Show("" + seleccionarItem);
                
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
                        CaballeroRosado.Left = 55 + c;
                        CaballeroRosado.Top = 65 + f;
                        
                        if (posicionA >= 49)
                        {
                            CaballeroRosado.Left = 15 + 300;
                            CaballeroRosado.Top = 5 + 300;
                            MessageBox.Show("GANO EL CABALLERO ROJO");
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
                            MessageBox.Show("GANO EL CABALLERO AZUL");
                            columnaMaquina = 0;
                            filaMaquina = 0;
                            posicionB = 0;
                            Iniciar();
                            
                        }
                        break;
                    }
            }
        }

    }
}
