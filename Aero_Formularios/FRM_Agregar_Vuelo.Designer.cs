namespace Aero_Formularios
{
    partial class FRM_Agregar_Vuelo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            PBVisualizacion = new PictureBox();
            label1 = new Label();
            CmbAeropuertoSalida = new ComboBox();
            label3 = new Label();
            CmbAeropuertoDestino = new ComboBox();
            label2 = new Label();
            CmbModeloAvion = new ComboBox();
            BtnAgregar = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblNombrePiloto = new Label();
            pbPiloto = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtPasajeros = new TextBox();
            Cronometro = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBVisualizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPiloto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PBVisualizacion);
            panel1.Location = new Point(612, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 225);
            panel1.TabIndex = 0;
            // 
            // PBVisualizacion
            // 
            PBVisualizacion.BorderStyle = BorderStyle.FixedSingle;
            PBVisualizacion.Location = new Point(3, 16);
            PBVisualizacion.Name = "PBVisualizacion";
            PBVisualizacion.Size = new Size(360, 188);
            PBVisualizacion.SizeMode = PictureBoxSizeMode.StretchImage;
            PBVisualizacion.TabIndex = 1;
            PBVisualizacion.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 263);
            label1.Name = "label1";
            label1.Size = new Size(199, 57);
            label1.TabIndex = 1;
            label1.Text = "Vuelo de";
            // 
            // CmbAeropuertoSalida
            // 
            CmbAeropuertoSalida.BackColor = Color.Gainsboro;
            CmbAeropuertoSalida.FlatStyle = FlatStyle.Popup;
            CmbAeropuertoSalida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbAeropuertoSalida.FormattingEnabled = true;
            CmbAeropuertoSalida.ImeMode = ImeMode.Katakana;
            CmbAeropuertoSalida.Items.AddRange(new object[] { "Tijuana", "Chihuahua", "Monterrey", "Puebla", "Ciudad de Mexico", "Acapulco", "Cancún", "Merida" });
            CmbAeropuertoSalida.Location = new Point(639, 275);
            CmbAeropuertoSalida.Name = "CmbAeropuertoSalida";
            CmbAeropuertoSalida.Size = new Size(211, 36);
            CmbAeropuertoSalida.TabIndex = 4;
            CmbAeropuertoSalida.Text = "Aeropuerto de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 337);
            label3.Name = "label3";
            label3.Size = new Size(280, 46);
            label3.TabIndex = 5;
            label3.Text = "con destino a";
            // 
            // CmbAeropuertoDestino
            // 
            CmbAeropuertoDestino.BackColor = Color.Gainsboro;
            CmbAeropuertoDestino.FlatStyle = FlatStyle.Popup;
            CmbAeropuertoDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbAeropuertoDestino.FormattingEnabled = true;
            CmbAeropuertoDestino.Items.AddRange(new object[] { "Tijuana", "Chihuahua", "Monterrey", "Puebla", "Ciudad de Mexico", "Acapulco", "Cancún", "Merida" });
            CmbAeropuertoDestino.Location = new Point(700, 347);
            CmbAeropuertoDestino.Name = "CmbAeropuertoDestino";
            CmbAeropuertoDestino.Size = new Size(224, 36);
            CmbAeropuertoDestino.TabIndex = 6;
            CmbAeropuertoDestino.Text = "Aeropuerto de destino";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 9);
            label2.Name = "label2";
            label2.Size = new Size(438, 45);
            label2.TabIndex = 7;
            label2.Text = "Avión listo para volar";
            // 
            // CmbModeloAvion
            // 
            CmbModeloAvion.BackColor = SystemColors.InactiveCaption;
            CmbModeloAvion.FlatStyle = FlatStyle.Popup;
            CmbModeloAvion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbModeloAvion.FormattingEnabled = true;
            CmbModeloAvion.ImeMode = ImeMode.Katakana;
            CmbModeloAvion.Items.AddRange(new object[] { "Boeing 737", "Airbus A320", "Embraer E-jet", "Bombardier CRJ", "Boeing 787", "Boeing 777" });
            CmbModeloAvion.Location = new Point(377, 77);
            CmbModeloAvion.Name = "CmbModeloAvion";
            CmbModeloAvion.Size = new Size(224, 36);
            CmbModeloAvion.TabIndex = 8;
            CmbModeloAvion.Text = "Modelo";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.ActiveCaption;
            BtnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.Control;
            BtnAgregar.Location = new Point(124, 427);
            BtnAgregar.Margin = new Padding(15);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(366, 70);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            iconPictureBox1.ErrorImage = Properties.Resources.avion;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 103;
            iconPictureBox1.InitialImage = Properties.Resources.avion;
            iconPictureBox1.Location = new Point(730, 406);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(213, 103);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // lblNombrePiloto
            // 
            lblNombrePiloto.AutoSize = true;
            lblNombrePiloto.BackColor = SystemColors.InactiveCaption;
            lblNombrePiloto.BorderStyle = BorderStyle.Fixed3D;
            lblNombrePiloto.FlatStyle = FlatStyle.System;
            lblNombrePiloto.Font = new Font("PT Bold Mirror", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblNombrePiloto.Location = new Point(163, 147);
            lblNombrePiloto.Name = "lblNombrePiloto";
            lblNombrePiloto.Size = new Size(63, 40);
            lblNombrePiloto.TabIndex = 11;
            lblNombrePiloto.Text = "text";
            // 
            // pbPiloto
            // 
            pbPiloto.BorderStyle = BorderStyle.FixedSingle;
            pbPiloto.Location = new Point(2, 89);
            pbPiloto.Name = "pbPiloto";
            pbPiloto.Size = new Size(150, 127);
            pbPiloto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPiloto.TabIndex = 12;
            pbPiloto.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(163, 77);
            label4.Name = "label4";
            label4.Size = new Size(180, 57);
            label4.TabIndex = 13;
            label4.Text = "Capitan";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 251);
            label5.Name = "label5";
            label5.Size = new Size(336, 41);
            label5.TabIndex = 15;
            label5.Text = "Cantidad de pasajeros";
            // 
            // txtPasajeros
            // 
            txtPasajeros.BackColor = Color.Silver;
            txtPasajeros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasajeros.Location = new Point(31, 312);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(163, 34);
            txtPasajeros.TabIndex = 16;
            // 
            // Cronometro
            // 
            Cronometro.Tick += Cronometro_Tick;
            // 
            // FRM_Agregar_Vuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 521);
            Controls.Add(txtPasajeros);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pbPiloto);
            Controls.Add(lblNombrePiloto);
            Controls.Add(iconPictureBox1);
            Controls.Add(BtnAgregar);
            Controls.Add(CmbModeloAvion);
            Controls.Add(label2);
            Controls.Add(CmbAeropuertoDestino);
            Controls.Add(label3);
            Controls.Add(CmbAeropuertoSalida);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FRM_Agregar_Vuelo";
            Text = "FRM";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBVisualizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPiloto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox PBVisualizacion;
        private Label label1;
        private ComboBox CmbAeropuertoSalida;
        private Label label3;
        private ComboBox CmbAeropuertoDestino;
        private Label label2;
        private ComboBox CmbModeloAvion;
        private Button BtnAgregar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblNombrePiloto;
        private PictureBox pbPiloto;
        private Label label4;
        private Label label5;
        private TextBox txtPasajeros;
        private System.Windows.Forms.Timer Cronometro;
    }
}