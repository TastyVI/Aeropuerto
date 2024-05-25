﻿namespace Aero_Formularios
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
            label2 = new Label();
            CmbModeloAvion = new ComboBox();
            label1 = new Label();
            CmbAeropuertoSalida = new ComboBox();
            label3 = new Label();
            CmbAeropuertoDestino = new ComboBox();
            BtnAgregar = new Button();
            lblNombrePiloto = new Label();
            pbPiloto = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtPasajeros = new TextBox();
            Cronometro = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBVisualizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPiloto).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 147, 163);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(PBVisualizacion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CmbModeloAvion);
            panel1.Location = new Point(482, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 280);
            panel1.TabIndex = 0;
            // 
            // PBVisualizacion
            // 
            PBVisualizacion.BorderStyle = BorderStyle.FixedSingle;
            PBVisualizacion.Location = new Point(226, 65);
            PBVisualizacion.Name = "PBVisualizacion";
            PBVisualizacion.Size = new Size(360, 189);
            PBVisualizacion.SizeMode = PictureBoxSizeMode.StretchImage;
            PBVisualizacion.TabIndex = 1;
            PBVisualizacion.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(34, 48, 38);
            label2.Location = new Point(226, 1);
            label2.Name = "label2";
            label2.Size = new Size(355, 44);
            label2.TabIndex = 7;
            label2.Text = "Avión listo para volar";
            // 
            // CmbModeloAvion
            // 
            CmbModeloAvion.BackColor = Color.FromArgb(65, 95, 107);
            CmbModeloAvion.FlatStyle = FlatStyle.Flat;
            CmbModeloAvion.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbModeloAvion.ForeColor = SystemColors.MenuBar;
            CmbModeloAvion.FormattingEnabled = true;
            CmbModeloAvion.ImeMode = ImeMode.Katakana;
            CmbModeloAvion.Items.AddRange(new object[] { "Boeing 737", "Airbus A320", "Embraer E-jet", "Bombardier CRJ", "Boeing 787", "Boeing 777" });
            CmbModeloAvion.Location = new Point(6, 91);
            CmbModeloAvion.Name = "CmbModeloAvion";
            CmbModeloAvion.Size = new Size(213, 38);
            CmbModeloAvion.TabIndex = 8;
            CmbModeloAvion.Text = "Modelo";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 48, 38);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(155, 40);
            label1.TabIndex = 1;
            label1.Text = "Vuelo de";
            // 
            // CmbAeropuertoSalida
            // 
            CmbAeropuertoSalida.BackColor = Color.FromArgb(65, 95, 107);
            CmbAeropuertoSalida.FlatStyle = FlatStyle.Popup;
            CmbAeropuertoSalida.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbAeropuertoSalida.ForeColor = Color.Gainsboro;
            CmbAeropuertoSalida.FormattingEnabled = true;
            CmbAeropuertoSalida.ImeMode = ImeMode.Katakana;
            CmbAeropuertoSalida.Items.AddRange(new object[] { "Tijuana", "Chihuahua", "Monterrey", "Puebla", "Ciudad de Mexico", "Acapulco", "Cancún", "Merida" });
            CmbAeropuertoSalida.Location = new Point(166, 1);
            CmbAeropuertoSalida.Name = "CmbAeropuertoSalida";
            CmbAeropuertoSalida.Size = new Size(270, 38);
            CmbAeropuertoSalida.TabIndex = 4;
            CmbAeropuertoSalida.Text = "Aeropuerto de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 48, 38);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(242, 40);
            label3.TabIndex = 5;
            label3.Text = "con destino a";
            // 
            // CmbAeropuertoDestino
            // 
            CmbAeropuertoDestino.BackColor = Color.FromArgb(65, 95, 107);
            CmbAeropuertoDestino.FlatStyle = FlatStyle.Popup;
            CmbAeropuertoDestino.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbAeropuertoDestino.ForeColor = Color.Gainsboro;
            CmbAeropuertoDestino.FormattingEnabled = true;
            CmbAeropuertoDestino.Items.AddRange(new object[] { "Tijuana", "Chihuahua", "Monterrey", "Puebla", "Ciudad de Mexico", "Acapulco", "Cancún", "Merida" });
            CmbAeropuertoDestino.Location = new Point(230, 47);
            CmbAeropuertoDestino.Name = "CmbAeropuertoDestino";
            CmbAeropuertoDestino.Size = new Size(276, 38);
            CmbAeropuertoDestino.TabIndex = 6;
            CmbAeropuertoDestino.Text = "Aeropuerto de destino";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(65, 95, 107);
            BtnAgregar.BackgroundImage = Properties.Resources.x;
            BtnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.Control;
            BtnAgregar.Location = new Point(6, 208);
            BtnAgregar.Margin = new Padding(15, 15, 15, 15);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(366, 69);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // lblNombrePiloto
            // 
            lblNombrePiloto.AutoSize = true;
            lblNombrePiloto.BackColor = Color.FromArgb(65, 95, 107);
            lblNombrePiloto.BorderStyle = BorderStyle.Fixed3D;
            lblNombrePiloto.FlatStyle = FlatStyle.System;
            lblNombrePiloto.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePiloto.ForeColor = Color.Gainsboro;
            lblNombrePiloto.Location = new Point(176, 109);
            lblNombrePiloto.Name = "lblNombrePiloto";
            lblNombrePiloto.Size = new Size(59, 32);
            lblNombrePiloto.TabIndex = 11;
            lblNombrePiloto.Text = "text";
            // 
            // pbPiloto
            // 
            pbPiloto.BorderStyle = BorderStyle.FixedSingle;
            pbPiloto.Location = new Point(18, 77);
            pbPiloto.Name = "pbPiloto";
            pbPiloto.Size = new Size(151, 127);
            pbPiloto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPiloto.TabIndex = 12;
            pbPiloto.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(34, 48, 38);
            label4.Location = new Point(8, 17);
            label4.Name = "label4";
            label4.Size = new Size(174, 45);
            label4.TabIndex = 13;
            label4.Text = "Capitán";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(34, 48, 38);
            label5.Location = new Point(3, 43);
            label5.Name = "label5";
            label5.Size = new Size(374, 45);
            label5.TabIndex = 15;
            label5.Text = "Cantidad de pasajeros";
            // 
            // txtPasajeros
            // 
            txtPasajeros.BackColor = Color.FromArgb(65, 95, 107);
            txtPasajeros.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasajeros.ForeColor = Color.Gainsboro;
            txtPasajeros.Location = new Point(103, 120);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(163, 37);
            txtPasajeros.TabIndex = 16;
            // 
            // Cronometro
            // 
            Cronometro.Tick += Cronometro_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 147, 163);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pbPiloto);
            panel2.Controls.Add(lblNombrePiloto);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(72, 36);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 227);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(107, 147, 163);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(CmbAeropuertoDestino);
            panel3.Controls.Add(CmbAeropuertoSalida);
            panel3.Location = new Point(485, 341);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 237);
            panel3.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.LogoAvion;
            pictureBox1.Location = new Point(397, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(107, 147, 163);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(BtnAgregar);
            panel4.Controls.Add(txtPasajeros);
            panel4.Location = new Point(63, 272);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 309);
            panel4.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1090, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 576);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // FRM_Agregar_Vuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 149, 160);
            ClientSize = new Size(1208, 588);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "FRM_Agregar_Vuelo";
            Text = "FRM";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBVisualizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPiloto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
        private Label lblNombrePiloto;
        private PictureBox pbPiloto;
        private Label label4;
        private Label label5;
        private TextBox txtPasajeros;
        private System.Windows.Forms.Timer Cronometro;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}