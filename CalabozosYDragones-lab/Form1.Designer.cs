﻿namespace CalabozosYDragones_lab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBdado = new System.Windows.Forms.PictureBox();
            this.dadoA = new System.Windows.Forms.Label();
            this.dadoR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragoncito = new System.Windows.Forms.Timer(this.components);
            this.dragoncito2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.DragonVerde2 = new System.Windows.Forms.Panel();
            this.DragonVerde1 = new System.Windows.Forms.Panel();
            this.DragonAzul2 = new System.Windows.Forms.Panel();
            this.DragonAzul1 = new System.Windows.Forms.Panel();
            this.DragonAmarillo2 = new System.Windows.Forms.Panel();
            this.DragonAmarillo1 = new System.Windows.Forms.Panel();
            this.CaballeroAmarillo = new System.Windows.Forms.Panel();
            this.CaballeroVerde = new System.Windows.Forms.Panel();
            this.DragonRosa2 = new System.Windows.Forms.Panel();
            this.DragonRosa1 = new System.Windows.Forms.Panel();
            this.Calabozo1 = new System.Windows.Forms.Panel();
            this.Calabozo3 = new System.Windows.Forms.Panel();
            this.Calabozo2 = new System.Windows.Forms.Panel();
            this.CaballeroAzul = new System.Windows.Forms.Panel();
            this.CaballeroRosa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Experto"});
            this.comboBox1.Location = new System.Drawing.Point(1606, 128);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBdado
            // 
            this.pBdado.Image = ((System.Drawing.Image)(resources.GetObject("pBdado.Image")));
            this.pBdado.Location = new System.Drawing.Point(1474, 512);
            this.pBdado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBdado.Name = "pBdado";
            this.pBdado.Size = new System.Drawing.Size(336, 320);
            this.pBdado.TabIndex = 7;
            this.pBdado.TabStop = false;
            // 
            // dadoA
            // 
            this.dadoA.AutoSize = true;
            this.dadoA.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoA.Location = new System.Drawing.Point(1551, 611);
            this.dadoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dadoA.Name = "dadoA";
            this.dadoA.Size = new System.Drawing.Size(0, 176);
            this.dadoA.TabIndex = 8;
            this.dadoA.VisibleChanged += new System.EventHandler(this.dadoA_VisibleChanged);
            // 
            // dadoR
            // 
            this.dadoR.AutoSize = true;
            this.dadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoR.Location = new System.Drawing.Point(1665, 97);
            this.dadoR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dadoR.Name = "dadoR";
            this.dadoR.Size = new System.Drawing.Size(0, 47);
            this.dadoR.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1374, 848);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dragoncito
            // 
            this.dragoncito.Tick += new System.EventHandler(this.dragoncito_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1410, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "NIVELES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1401, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "JUGADORES";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDown1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(1606, 209);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(204, 46);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 1200;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1494, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 105);
            this.button1.TabIndex = 18;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DragonVerde2
            // 
            this.DragonVerde2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonVerde2.BackgroundImage")));
            this.DragonVerde2.Location = new System.Drawing.Point(416, 903);
            this.DragonVerde2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonVerde2.Name = "DragonVerde2";
            this.DragonVerde2.Size = new System.Drawing.Size(70, 106);
            this.DragonVerde2.TabIndex = 30;
            // 
            // DragonVerde1
            // 
            this.DragonVerde1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonVerde1.BackgroundImage")));
            this.DragonVerde1.Location = new System.Drawing.Point(336, 903);
            this.DragonVerde1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonVerde1.Name = "DragonVerde1";
            this.DragonVerde1.Size = new System.Drawing.Size(70, 106);
            this.DragonVerde1.TabIndex = 29;
            // 
            // DragonAzul2
            // 
            this.DragonAzul2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAzul2.BackgroundImage")));
            this.DragonAzul2.Location = new System.Drawing.Point(256, 903);
            this.DragonAzul2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonAzul2.Name = "DragonAzul2";
            this.DragonAzul2.Size = new System.Drawing.Size(70, 106);
            this.DragonAzul2.TabIndex = 28;
            // 
            // DragonAzul1
            // 
            this.DragonAzul1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAzul1.BackgroundImage")));
            this.DragonAzul1.Location = new System.Drawing.Point(177, 903);
            this.DragonAzul1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonAzul1.Name = "DragonAzul1";
            this.DragonAzul1.Size = new System.Drawing.Size(70, 106);
            this.DragonAzul1.TabIndex = 26;
            // 
            // DragonAmarillo2
            // 
            this.DragonAmarillo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAmarillo2.BackgroundImage")));
            this.DragonAmarillo2.Location = new System.Drawing.Point(98, 903);
            this.DragonAmarillo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonAmarillo2.Name = "DragonAmarillo2";
            this.DragonAmarillo2.Size = new System.Drawing.Size(70, 106);
            this.DragonAmarillo2.TabIndex = 27;
            this.DragonAmarillo2.Paint += new System.Windows.Forms.PaintEventHandler(this.DragonAmarillo2_Paint);
            // 
            // DragonAmarillo1
            // 
            this.DragonAmarillo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAmarillo1.BackgroundImage")));
            this.DragonAmarillo1.Location = new System.Drawing.Point(18, 902);
            this.DragonAmarillo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonAmarillo1.Name = "DragonAmarillo1";
            this.DragonAmarillo1.Size = new System.Drawing.Size(70, 106);
            this.DragonAmarillo1.TabIndex = 24;
            // 
            // CaballeroAmarillo
            // 
            this.CaballeroAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroAmarillo.BackgroundImage")));
            this.CaballeroAmarillo.Location = new System.Drawing.Point(609, 888);
            this.CaballeroAmarillo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaballeroAmarillo.Name = "CaballeroAmarillo";
            this.CaballeroAmarillo.Size = new System.Drawing.Size(69, 97);
            this.CaballeroAmarillo.TabIndex = 21;
            // 
            // CaballeroVerde
            // 
            this.CaballeroVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroVerde.BackgroundImage")));
            this.CaballeroVerde.Location = new System.Drawing.Point(531, 888);
            this.CaballeroVerde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaballeroVerde.Name = "CaballeroVerde";
            this.CaballeroVerde.Size = new System.Drawing.Size(69, 97);
            this.CaballeroVerde.TabIndex = 22;
            // 
            // DragonRosa2
            // 
            this.DragonRosa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonRosa2.BackgroundImage")));
            this.DragonRosa2.Location = new System.Drawing.Point(1316, 888);
            this.DragonRosa2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonRosa2.Name = "DragonRosa2";
            this.DragonRosa2.Size = new System.Drawing.Size(70, 106);
            this.DragonRosa2.TabIndex = 25;
            // 
            // DragonRosa1
            // 
            this.DragonRosa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonRosa1.BackgroundImage")));
            this.DragonRosa1.Location = new System.Drawing.Point(1200, 888);
            this.DragonRosa1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DragonRosa1.Name = "DragonRosa1";
            this.DragonRosa1.Size = new System.Drawing.Size(70, 106);
            this.DragonRosa1.TabIndex = 23;
            // 
            // Calabozo1
            // 
            this.Calabozo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo1.BackgroundImage")));
            this.Calabozo1.Location = new System.Drawing.Point(844, 888);
            this.Calabozo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calabozo1.Name = "Calabozo1";
            this.Calabozo1.Size = new System.Drawing.Size(79, 97);
            this.Calabozo1.TabIndex = 32;
            // 
            // Calabozo3
            // 
            this.Calabozo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo3.BackgroundImage")));
            this.Calabozo3.Location = new System.Drawing.Point(1070, 888);
            this.Calabozo3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calabozo3.Name = "Calabozo3";
            this.Calabozo3.Size = new System.Drawing.Size(79, 97);
            this.Calabozo3.TabIndex = 33;
            // 
            // Calabozo2
            // 
            this.Calabozo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo2.BackgroundImage")));
            this.Calabozo2.Location = new System.Drawing.Point(957, 888);
            this.Calabozo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calabozo2.Name = "Calabozo2";
            this.Calabozo2.Size = new System.Drawing.Size(79, 97);
            this.Calabozo2.TabIndex = 31;
            // 
            // CaballeroAzul
            // 
            this.CaballeroAzul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroAzul.BackgroundImage")));
            this.CaballeroAzul.Location = new System.Drawing.Point(687, 888);
            this.CaballeroAzul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaballeroAzul.Name = "CaballeroAzul";
            this.CaballeroAzul.Size = new System.Drawing.Size(69, 97);
            this.CaballeroAzul.TabIndex = 20;
            // 
            // CaballeroRosa
            // 
            this.CaballeroRosa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroRosa.BackgroundImage")));
            this.CaballeroRosa.Location = new System.Drawing.Point(765, 888);
            this.CaballeroRosa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaballeroRosa.Name = "CaballeroRosa";
            this.CaballeroRosa.Size = new System.Drawing.Size(70, 97);
            this.CaballeroRosa.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1894, 1054);
            this.Controls.Add(this.DragonVerde2);
            this.Controls.Add(this.DragonVerde1);
            this.Controls.Add(this.DragonAzul2);
            this.Controls.Add(this.DragonAzul1);
            this.Controls.Add(this.DragonAmarillo2);
            this.Controls.Add(this.DragonAmarillo1);
            this.Controls.Add(this.CaballeroAmarillo);
            this.Controls.Add(this.CaballeroVerde);
            this.Controls.Add(this.DragonRosa2);
            this.Controls.Add(this.DragonRosa1);
            this.Controls.Add(this.Calabozo1);
            this.Controls.Add(this.Calabozo3);
            this.Controls.Add(this.Calabozo2);
            this.Controls.Add(this.CaballeroAzul);
            this.Controls.Add(this.CaballeroRosa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBdado);
            this.Controls.Add(this.dadoR);
            this.Controls.Add(this.dadoA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalabozosYDragones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBdado;
        private System.Windows.Forms.Label dadoA;
        private System.Windows.Forms.Label dadoR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dragoncito;
        private System.Windows.Forms.Timer dragoncito2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel DragonVerde2;
        private System.Windows.Forms.Panel DragonVerde1;
        private System.Windows.Forms.Panel DragonAzul2;
        private System.Windows.Forms.Panel DragonAzul1;
        private System.Windows.Forms.Panel DragonAmarillo2;
        private System.Windows.Forms.Panel DragonAmarillo1;
        private System.Windows.Forms.Panel CaballeroAmarillo;
        private System.Windows.Forms.Panel CaballeroVerde;
        private System.Windows.Forms.Panel DragonRosa2;
        private System.Windows.Forms.Panel DragonRosa1;
        private System.Windows.Forms.Panel Calabozo1;
        private System.Windows.Forms.Panel Calabozo3;
        private System.Windows.Forms.Panel Calabozo2;
        private System.Windows.Forms.Panel CaballeroAzul;
        private System.Windows.Forms.Panel CaballeroRosa;
    }
}

