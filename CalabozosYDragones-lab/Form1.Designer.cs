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
            this.CaballeroRojo = new System.Windows.Forms.Panel();
            this.CaballeroAzul = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DragoncitoHumano1 = new System.Windows.Forms.Panel();
            this.DragoncitoHumano2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnHumano = new System.Windows.Forms.Button();
            this.BtnMaquina = new System.Windows.Forms.Button();
            this.pBdado = new System.Windows.Forms.PictureBox();
            this.dadoA = new System.Windows.Forms.Label();
            this.dadoR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragoncito = new System.Windows.Forms.Timer(this.components);
            this.dragoncito2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Calabozo2 = new System.Windows.Forms.Panel();
            this.Calabozo1 = new System.Windows.Forms.Panel();
            this.Calabozo3 = new System.Windows.Forms.Panel();
            this.listaVirtual = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CaballeroRojo
            // 
            this.CaballeroRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroRojo.BackgroundImage")));
            this.CaballeroRojo.Location = new System.Drawing.Point(549, 516);
            this.CaballeroRojo.Name = "CaballeroRojo";
            this.CaballeroRojo.Size = new System.Drawing.Size(47, 63);
            this.CaballeroRojo.TabIndex = 1;
            // 
            // CaballeroAzul
            // 
            this.CaballeroAzul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaballeroAzul.BackgroundImage")));
            this.CaballeroAzul.Location = new System.Drawing.Point(412, 535);
            this.CaballeroAzul.Name = "CaballeroAzul";
            this.CaballeroAzul.Size = new System.Drawing.Size(46, 63);
            this.CaballeroAzul.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Experto"});
            this.comboBox1.Location = new System.Drawing.Point(959, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DragoncitoHumano1
            // 
            this.DragoncitoHumano1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragoncitoHumano1.BackgroundImage")));
            this.DragoncitoHumano1.Location = new System.Drawing.Point(934, 212);
            this.DragoncitoHumano1.Name = "DragoncitoHumano1";
            this.DragoncitoHumano1.Size = new System.Drawing.Size(51, 84);
            this.DragoncitoHumano1.TabIndex = 3;
            this.DragoncitoHumano1.Paint += new System.Windows.Forms.PaintEventHandler(this.DragoncitoHumano1_Paint);
            // 
            // DragoncitoHumano2
            // 
            this.DragoncitoHumano2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragoncitoHumano2.BackgroundImage")));
            this.DragoncitoHumano2.Location = new System.Drawing.Point(934, 140);
            this.DragoncitoHumano2.Name = "DragoncitoHumano2";
            this.DragoncitoHumano2.Size = new System.Drawing.Size(51, 84);
            this.DragoncitoHumano2.TabIndex = 4;
            this.DragoncitoHumano2.Paint += new System.Windows.Forms.PaintEventHandler(this.DragoncitoHumano2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel5.Location = new System.Drawing.Point(936, 302);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(51, 84);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnHumano
            // 
            this.BtnHumano.Location = new System.Drawing.Point(987, 47);
            this.BtnHumano.Name = "BtnHumano";
            this.BtnHumano.Size = new System.Drawing.Size(75, 23);
            this.BtnHumano.TabIndex = 5;
            this.BtnHumano.Text = "Humano";
            this.BtnHumano.UseVisualStyleBackColor = true;
            this.BtnHumano.Click += new System.EventHandler(this.BtnHumano_Click_1);
            // 
            // BtnMaquina
            // 
            this.BtnMaquina.Location = new System.Drawing.Point(987, 76);
            this.BtnMaquina.Name = "BtnMaquina";
            this.BtnMaquina.Size = new System.Drawing.Size(75, 23);
            this.BtnMaquina.TabIndex = 6;
            this.BtnMaquina.Text = "Maquina";
            this.BtnMaquina.UseVisualStyleBackColor = true;
            this.BtnMaquina.Click += new System.EventHandler(this.BtnMaquina_Click);
            // 
            // pBdado
            // 
            this.pBdado.Image = ((System.Drawing.Image)(resources.GetObject("pBdado.Image")));
            this.pBdado.Location = new System.Drawing.Point(1015, 131);
            this.pBdado.Name = "pBdado";
            this.pBdado.Size = new System.Drawing.Size(224, 208);
            this.pBdado.TabIndex = 7;
            this.pBdado.TabStop = false;
            // 
            // dadoA
            // 
            this.dadoA.AutoSize = true;
            this.dadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoA.Location = new System.Drawing.Point(1110, 236);
            this.dadoA.Name = "dadoA";
            this.dadoA.Size = new System.Drawing.Size(0, 31);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1068, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Humano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calabozo2
            // 
            this.Calabozo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo2.BackgroundImage")));
            this.Calabozo2.Location = new System.Drawing.Point(1068, 359);
            this.Calabozo2.Name = "Calabozo2";
            this.Calabozo2.Size = new System.Drawing.Size(69, 78);
            this.Calabozo2.TabIndex = 12;
            // 
            // Calabozo1
            // 
            this.Calabozo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo1.BackgroundImage")));
            this.Calabozo1.Location = new System.Drawing.Point(993, 359);
            this.Calabozo1.Name = "Calabozo1";
            this.Calabozo1.Size = new System.Drawing.Size(69, 78);
            this.Calabozo1.TabIndex = 13;
            // 
            // Calabozo3
            // 
            this.Calabozo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calabozo3.BackgroundImage")));
            this.Calabozo3.Location = new System.Drawing.Point(1143, 359);
            this.Calabozo3.Name = "Calabozo3";
            this.Calabozo3.Size = new System.Drawing.Size(69, 78);
            this.Calabozo3.TabIndex = 13;
            // 
            // listaVirtual
            // 
            this.listaVirtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaVirtual.FormattingEnabled = true;
            this.listaVirtual.Items.AddRange(new object[] {
            "Virtual1",
            "Virtual2",
            "Virtual3"});
            this.listaVirtual.Location = new System.Drawing.Point(1015, 472);
            this.listaVirtual.Name = "listaVirtual";
            this.listaVirtual.Size = new System.Drawing.Size(121, 21);
            this.listaVirtual.TabIndex = 14;
            this.listaVirtual.SelectedIndexChanged += new System.EventHandler(this.listaVirtual_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 606);
            this.Controls.Add(this.listaVirtual);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DragoncitoHumano2);
            this.Controls.Add(this.DragoncitoHumano1);
            this.Controls.Add(this.Calabozo1);
            this.Controls.Add(this.Calabozo3);
            this.Controls.Add(this.Calabozo2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CaballeroAzul);
            this.Controls.Add(this.CaballeroRojo);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel CaballeroRojo;
        private System.Windows.Forms.Panel CaballeroAzul;
        private System.Windows.Forms.Panel DragoncitoHumano1;
        private System.Windows.Forms.Panel DragoncitoHumano2;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Calabozo2;
        private System.Windows.Forms.Panel Calabozo1;
        private System.Windows.Forms.Panel Calabozo3;
        public System.Windows.Forms.ComboBox listaVirtual;
    }
}

