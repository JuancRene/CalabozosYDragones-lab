namespace CalabozosYDragones_lab
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
            this.CaballeroRosa = new System.Windows.Forms.Panel();
            this.CaballeroAzul = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DragoncitoHumano1 = new System.Windows.Forms.Panel();
            this.DragoncitoHumano2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnHumano = new System.Windows.Forms.Button();
            this.BtnMaquina = new System.Windows.Forms.Button();
            this.pBdado = new System.Windows.Forms.PictureBox();
            this.dadoA = new System.Windows.Forms.Label();
            this.dadoR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragoncito = new System.Windows.Forms.Timer(this.components);
            this.dragoncito2 = new System.Windows.Forms.Timer(this.components);
            this.Calabozo2 = new System.Windows.Forms.Panel();
            this.Calabozo1 = new System.Windows.Forms.Panel();
            this.Calabozo3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.CaballeroVerde = new System.Windows.Forms.Panel();
            this.CaballeroAmarillo = new System.Windows.Forms.Panel();
            this.BtnMaquina2 = new System.Windows.Forms.Button();
            this.BtnMaquina3 = new System.Windows.Forms.Button();
            this.DragonAmarillo1 = new System.Windows.Forms.Panel();
            this.DragonAmarillo2 = new System.Windows.Forms.Panel();
            this.DragonAzul1 = new System.Windows.Forms.Panel();
            this.DragonAzul2 = new System.Windows.Forms.Panel();
            this.DragonVerde1 = new System.Windows.Forms.Panel();
            this.DragonVerde2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CaballeroRosa
            // 
            this.CaballeroRosa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroRosa.BackgroundImage")));
            this.CaballeroRosa.Location = new System.Drawing.Point(510, 567);
            this.CaballeroRosa.Name = "CaballeroRosa";
            this.CaballeroRosa.Size = new System.Drawing.Size(47, 63);
            this.CaballeroRosa.TabIndex = 1;
            this.CaballeroRosa.Paint += new System.Windows.Forms.PaintEventHandler(this.CaballeroRojo_Paint);
            // 
            // CaballeroAzul
            // 
            this.CaballeroAzul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroAzul.BackgroundImage")));
            this.CaballeroAzul.Location = new System.Drawing.Point(458, 567);
            this.CaballeroAzul.Name = "CaballeroAzul";
            this.CaballeroAzul.Size = new System.Drawing.Size(46, 63);
            this.CaballeroAzul.TabIndex = 2;
            this.CaballeroAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.CaballeroAzul_Paint);
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
            this.comboBox1.Location = new System.Drawing.Point(1071, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DragoncitoHumano1
            // 
            this.DragoncitoHumano1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragoncitoHumano1.BackgroundImage")));
            this.DragoncitoHumano1.Location = new System.Drawing.Point(800, 567);
            this.DragoncitoHumano1.Name = "DragoncitoHumano1";
            this.DragoncitoHumano1.Size = new System.Drawing.Size(47, 69);
            this.DragoncitoHumano1.TabIndex = 3;
            this.DragoncitoHumano1.Paint += new System.Windows.Forms.PaintEventHandler(this.DragoncitoHumano1_Paint);
            // 
            // DragoncitoHumano2
            // 
            this.DragoncitoHumano2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragoncitoHumano2.BackgroundImage")));
            this.DragoncitoHumano2.Location = new System.Drawing.Point(877, 567);
            this.DragoncitoHumano2.Name = "DragoncitoHumano2";
            this.DragoncitoHumano2.Size = new System.Drawing.Size(47, 69);
            this.DragoncitoHumano2.TabIndex = 4;
            this.DragoncitoHumano2.Paint += new System.Windows.Forms.PaintEventHandler(this.DragoncitoHumano2_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnHumano
            // 
            this.BtnHumano.Location = new System.Drawing.Point(970, 221);
            this.BtnHumano.Name = "BtnHumano";
            this.BtnHumano.Size = new System.Drawing.Size(103, 88);
            this.BtnHumano.TabIndex = 5;
            this.BtnHumano.Text = "Humano";
            this.BtnHumano.UseVisualStyleBackColor = true;
            this.BtnHumano.Click += new System.EventHandler(this.BtnHumano_Click_1);
            // 
            // BtnMaquina
            // 
            this.BtnMaquina.Location = new System.Drawing.Point(1087, 221);
            this.BtnMaquina.Name = "BtnMaquina";
            this.BtnMaquina.Size = new System.Drawing.Size(107, 88);
            this.BtnMaquina.TabIndex = 6;
            this.BtnMaquina.Text = "Maquina 1";
            this.BtnMaquina.UseVisualStyleBackColor = true;
            this.BtnMaquina.Click += new System.EventHandler(this.BtnMaquina_Click);
            // 
            // pBdado
            // 
            this.pBdado.Image = ((System.Drawing.Image)(resources.GetObject("pBdado.Image")));
            this.pBdado.Location = new System.Drawing.Point(970, 437);
            this.pBdado.Name = "pBdado";
            this.pBdado.Size = new System.Drawing.Size(224, 208);
            this.pBdado.TabIndex = 7;
            this.pBdado.TabStop = false;
            // 
            // dadoA
            // 
            this.dadoA.AutoSize = true;
            this.dadoA.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoA.Location = new System.Drawing.Point(1073, 470);
            this.dadoA.Name = "dadoA";
            this.dadoA.Size = new System.Drawing.Size(0, 117);
            this.dadoA.TabIndex = 8;
            this.dadoA.VisibleChanged += new System.EventHandler(this.dadoA_VisibleChanged);
            // 
            // dadoR
            // 
            this.dadoR.AutoSize = true;
            this.dadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoR.Location = new System.Drawing.Point(1110, 63);
            this.dadoR.Name = "dadoR";
            this.dadoR.Size = new System.Drawing.Size(0, 31);
            this.dadoR.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dragoncito
            // 
            this.dragoncito.Tick += new System.EventHandler(this.dragoncito_Tick);
            // 
            // Calabozo2
            // 
            this.Calabozo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo2.BackgroundImage")));
            this.Calabozo2.Location = new System.Drawing.Point(638, 567);
            this.Calabozo2.Name = "Calabozo2";
            this.Calabozo2.Size = new System.Drawing.Size(69, 78);
            this.Calabozo2.TabIndex = 12;
            // 
            // Calabozo1
            // 
            this.Calabozo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo1.BackgroundImage")));
            this.Calabozo1.Location = new System.Drawing.Point(563, 567);
            this.Calabozo1.Name = "Calabozo1";
            this.Calabozo1.Size = new System.Drawing.Size(69, 78);
            this.Calabozo1.TabIndex = 13;
            // 
            // Calabozo3
            // 
            this.Calabozo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo3.BackgroundImage")));
            this.Calabozo3.Location = new System.Drawing.Point(713, 567);
            this.Calabozo3.Name = "Calabozo3";
            this.Calabozo3.Size = new System.Drawing.Size(69, 78);
            this.Calabozo3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(940, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "NIVELES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(934, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "JUGADORES";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDown1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(1071, 63);
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
            this.numericUpDown1.Size = new System.Drawing.Size(136, 33);
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
            this.button1.Location = new System.Drawing.Point(992, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 68);
            this.button1.TabIndex = 18;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CaballeroVerde
            // 
            this.CaballeroVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroVerde.BackgroundImage")));
            this.CaballeroVerde.Location = new System.Drawing.Point(354, 567);
            this.CaballeroVerde.Name = "CaballeroVerde";
            this.CaballeroVerde.Size = new System.Drawing.Size(46, 63);
            this.CaballeroVerde.TabIndex = 3;
            // 
            // CaballeroAmarillo
            // 
            this.CaballeroAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroAmarillo.BackgroundImage")));
            this.CaballeroAmarillo.Location = new System.Drawing.Point(406, 567);
            this.CaballeroAmarillo.Name = "CaballeroAmarillo";
            this.CaballeroAmarillo.Size = new System.Drawing.Size(46, 63);
            this.CaballeroAmarillo.TabIndex = 3;
            // 
            // BtnMaquina2
            // 
            this.BtnMaquina2.Location = new System.Drawing.Point(970, 328);
            this.BtnMaquina2.Name = "BtnMaquina2";
            this.BtnMaquina2.Size = new System.Drawing.Size(107, 88);
            this.BtnMaquina2.TabIndex = 19;
            this.BtnMaquina2.Text = "Maquina 2";
            this.BtnMaquina2.UseVisualStyleBackColor = true;
            this.BtnMaquina2.Click += new System.EventHandler(this.BtnMaquina2_Click);
            // 
            // BtnMaquina3
            // 
            this.BtnMaquina3.Location = new System.Drawing.Point(1087, 328);
            this.BtnMaquina3.Name = "BtnMaquina3";
            this.BtnMaquina3.Size = new System.Drawing.Size(107, 88);
            this.BtnMaquina3.TabIndex = 20;
            this.BtnMaquina3.Text = "Maquina 3";
            this.BtnMaquina3.UseVisualStyleBackColor = true;
            this.BtnMaquina3.Click += new System.EventHandler(this.BtnMaquina3_Click);
            // 
            // DragonAmarillo1
            // 
            this.DragonAmarillo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAmarillo1.BackgroundImage")));
            this.DragonAmarillo1.Location = new System.Drawing.Point(12, 576);
            this.DragonAmarillo1.Name = "DragonAmarillo1";
            this.DragonAmarillo1.Size = new System.Drawing.Size(47, 69);
            this.DragonAmarillo1.TabIndex = 4;
            // 
            // DragonAmarillo2
            // 
            this.DragonAmarillo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAmarillo2.BackgroundImage")));
            this.DragonAmarillo2.Location = new System.Drawing.Point(65, 577);
            this.DragonAmarillo2.Name = "DragonAmarillo2";
            this.DragonAmarillo2.Size = new System.Drawing.Size(47, 69);
            this.DragonAmarillo2.TabIndex = 5;
            // 
            // DragonAzul1
            // 
            this.DragonAzul1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAzul1.BackgroundImage")));
            this.DragonAzul1.Location = new System.Drawing.Point(118, 577);
            this.DragonAzul1.Name = "DragonAzul1";
            this.DragonAzul1.Size = new System.Drawing.Size(47, 69);
            this.DragonAzul1.TabIndex = 5;
            // 
            // DragonAzul2
            // 
            this.DragonAzul2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonAzul2.BackgroundImage")));
            this.DragonAzul2.Location = new System.Drawing.Point(171, 577);
            this.DragonAzul2.Name = "DragonAzul2";
            this.DragonAzul2.Size = new System.Drawing.Size(47, 69);
            this.DragonAzul2.TabIndex = 6;
            // 
            // DragonVerde1
            // 
            this.DragonVerde1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonVerde1.BackgroundImage")));
            this.DragonVerde1.Location = new System.Drawing.Point(224, 577);
            this.DragonVerde1.Name = "DragonVerde1";
            this.DragonVerde1.Size = new System.Drawing.Size(47, 69);
            this.DragonVerde1.TabIndex = 7;
            // 
            // DragonVerde2
            // 
            this.DragonVerde2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragonVerde2.BackgroundImage")));
            this.DragonVerde2.Location = new System.Drawing.Point(277, 577);
            this.DragonVerde2.Name = "DragonVerde2";
            this.DragonVerde2.Size = new System.Drawing.Size(47, 69);
            this.DragonVerde2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1263, 658);
            this.Controls.Add(this.DragonVerde2);
            this.Controls.Add(this.DragonVerde1);
            this.Controls.Add(this.DragonAzul2);
            this.Controls.Add(this.DragonAzul1);
            this.Controls.Add(this.DragonAmarillo2);
            this.Controls.Add(this.DragonAmarillo1);
            this.Controls.Add(this.BtnMaquina3);
            this.Controls.Add(this.BtnMaquina2);
            this.Controls.Add(this.CaballeroAmarillo);
            this.Controls.Add(this.CaballeroVerde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DragoncitoHumano2);
            this.Controls.Add(this.DragoncitoHumano1);
            this.Controls.Add(this.Calabozo1);
            this.Controls.Add(this.Calabozo3);
            this.Controls.Add(this.Calabozo2);
            this.Controls.Add(this.CaballeroAzul);
            this.Controls.Add(this.CaballeroRosa);
            this.Controls.Add(this.pBdado);
            this.Controls.Add(this.dadoR);
            this.Controls.Add(this.dadoA);
            this.Controls.Add(this.BtnMaquina);
            this.Controls.Add(this.BtnHumano);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Panel CaballeroRosa;
        private System.Windows.Forms.Panel CaballeroAzul;
        private System.Windows.Forms.Panel DragoncitoHumano1;
        private System.Windows.Forms.Panel DragoncitoHumano2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnHumano;
        private System.Windows.Forms.Button BtnMaquina;
        private System.Windows.Forms.PictureBox pBdado;
        private System.Windows.Forms.Label dadoA;
        private System.Windows.Forms.Label dadoR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dragoncito;
        private System.Windows.Forms.Timer dragoncito2;
        private System.Windows.Forms.Panel Calabozo2;
        private System.Windows.Forms.Panel Calabozo1;
        private System.Windows.Forms.Panel Calabozo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel CaballeroVerde;
        private System.Windows.Forms.Panel CaballeroAmarillo;
        private System.Windows.Forms.Button BtnMaquina2;
        private System.Windows.Forms.Button BtnMaquina3;
        private System.Windows.Forms.Panel DragonAmarillo1;
        private System.Windows.Forms.Panel DragonAmarillo2;
        private System.Windows.Forms.Panel DragonAzul1;
        private System.Windows.Forms.Panel DragonAzul2;
        private System.Windows.Forms.Panel DragonVerde1;
        private System.Windows.Forms.Panel DragonVerde2;
    }
}

