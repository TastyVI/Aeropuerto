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
            panel1 = new Panel();
            PBVisualizacion = new PictureBox();
            label1 = new Label();
            CmbAeropuertoSalida = new ComboBox();
            label3 = new Label();
            CmbAeropuertoDestino = new ComboBox();
            label2 = new Label();
            CmbModeloAvion = new ComboBox();
            BtnAgregar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBVisualizacion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PBVisualizacion);
            panel1.Location = new Point(612, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 317);
            panel1.TabIndex = 0;
            // 
            // PBVisualizacion
            // 
            PBVisualizacion.Location = new Point(34, 16);
            PBVisualizacion.Name = "PBVisualizacion";
            PBVisualizacion.Size = new Size(329, 285);
            PBVisualizacion.SizeMode = PictureBoxSizeMode.StretchImage;
            PBVisualizacion.TabIndex = 1;
            PBVisualizacion.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 224);
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
            CmbAeropuertoSalida.Location = new Point(184, 293);
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
            label3.Location = new Point(283, 346);
            label3.Name = "label3";
            label3.Size = new Size(246, 46);
            label3.TabIndex = 5;
            label3.Text = "con destino";
            // 
            // CmbAeropuertoDestino
            // 
            CmbAeropuertoDestino.BackColor = Color.Gainsboro;
            CmbAeropuertoDestino.FlatStyle = FlatStyle.Popup;
            CmbAeropuertoDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbAeropuertoDestino.FormattingEnabled = true;
            CmbAeropuertoDestino.Items.AddRange(new object[] { "Tijuana", "Chihuahua", "Monterrey", "Puebla", "Ciudad de Mexico", "Acapulco", "Cancún", "Merida" });
            CmbAeropuertoDestino.Location = new Point(410, 405);
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
            label2.Location = new Point(12, 111);
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
            CmbModeloAvion.Location = new Point(12, 175);
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
            BtnAgregar.Location = new Point(145, 439);
            BtnAgregar.Margin = new Padding(15);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(179, 70);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // FRM_Agregar_Vuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 521);
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
    }
}