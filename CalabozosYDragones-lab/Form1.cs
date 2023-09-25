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
using System.Runtime.Remoting.Messaging;

namespace CalabozosYDragones_lab
{
    public partial class Form1 : Form
    {
        static Panel Hola { get; set; }
        Random dragon1 = new Random();
        Random dragon2 = new Random();
        Random dado = new Random();
        GameOver game = new GameOver();
        Sistema sistema = new Sistema();
        Intermedio intermedio;

        Caballero caballero =  new Caballero(Hola);
        Dragones dragones;
        Pieza pieza;
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
            


            dadoA.Visible = false;
            jugador = 1;
            pBdado.Visible = true;
            timer1.Stop();
            timer1.Start();
            posicionA += caballero.Mover();
            c = (posicionA % 10) * 90;
            f = (posicionA / 10) * 90;
            dadoA.Text = sistema.Posicion.ToString();
            
            //posicionA = intermedio.RetrocesoDragon1();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBdado.Visible = false;
            dadoA.Visible = true;
        }

        private void Iniciar()
        {
            caballero.PosicionInicialCaballero(CaballeroRosa);
            caballero.PosicionInicialCaballero(CaballeroAzul);

            
            //dragones.PosicionInicialDH(DragoncitoHumano1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Calabozo1.Visible = false;
            Calabozo2.Visible = false;
            Calabozo3.Visible = false;
            DragonRosa1.Visible = false;
            DragonRosa2.Visible = false;
            CaballeroAmarillo.Visible = false;
            CaballeroAzul.Visible = false;
            CaballeroRosa.Visible = false;
            CaballeroVerde.Visible = false;
            DragonAmarillo1.Visible= false;
            DragonAmarillo2.Visible = false;
            DragonAzul1.Visible = false;
            DragonAzul2.Visible = false;
            DragonVerde1.Visible=false;
            DragonVerde2.Visible=false;


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
            //posicionB += caballero.Mover();
            columnaMaquina = (posicionB % 10) * 90;
            filaMaquina = (posicionB / 10) * 90;
            dadoA.Text = pieza.Posicion.ToString();

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

            if(comboBox1.SelectedIndex == 1)
            {
                //#region Dragon1
                //dragones.PosicionInicialDragones(DragonRosa1);
                //sistema.ColumnaDragon1 = (DragonHumano % 10) * 90;
                //sistema.FilaDragon1 = (DragonHumano / 10) * 90;

                //#endregion

                //#region Dragon2

                //dragones.PosicionInicialDragones(DragonRosa2);
                //sistema.ColumnaDragon2 = (DragonHumano2 % 10) * 90;
                //sistema.FilaDragon2 = (DragonHumano2 / 10) * 90;

                //DragonRosa1.Visible = true;
                //DragonRosa2.Visible = true;


                //#endregion
                
                intermedio = new Intermedio(dragones.Posicion, Convert.ToInt32(numericUpDown1.Value));


            }

            //decimal NroDeJugadores;
            //NroDeJugadores = numericUpDown1.Value;

            //if(NroDeJugadores == 1)
            //{
            //    CaballeroAzul.Visible = true;
            //}
            //if(NroDeJugadores == 2)
            //{

            //}

            //BtnHumano.Enabled = true;
            //BtnMaquina.Enabled = true;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             
            
        }

        private void DragonAmarillo2_Paint(object sender, PaintEventArgs e)
        {

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
                dragones = new Dragones(DragonRosa1);
                dragones = new Dragones(DragonRosa2);
                //dragones = new Dragones(DragonAzul1);
                //dragones = new Dragones(DragonAzul2);
                dragones.PosicionInicialDragones(DragonRosa1);
                dragones.PosicionInicialDragones(DragonRosa2);
                //dragones.PosicionInicialDragones(DragonAzul1);
                //dragones.PosicionInicialDragones(DragonAzul2);

                DragonRosa1.Visible = true;
                DragonRosa2.Visible = true;

            }
            
        }

        private void dadoA_VisibleChanged(object sender, EventArgs e)
        {
            switch (jugador)
            {
                case 1:
                    {

                        DragonRosa2.Left = 55 + sistema.ColumnaDragon2;
                        DragonRosa2.Top = 65 + sistema.FilaDragon2;
                        DragonRosa1.Left = 55 + sistema.ColumnaDragon1;
                        DragonRosa1.Top = 65 + sistema.FilaDragon1;
                        CaballeroRosa.Left = 55 + c;
                        CaballeroRosa.Top = 65 + f;
                        
                        if (posicionA >= 49)
                        {
                            CaballeroRosa.Left = 15 + 300;
                            CaballeroRosa.Top = 5 + 300;
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
