namespace Aero_Formularios
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardarAvion = new Button();
            btnEliminarAvion = new Button();
            btnProgramarVuelo = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dgvAviones = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            btnGuardarUsuario = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAviones).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarAvion
            // 
            btnGuardarAvion.Location = new Point(81, 244);
            btnGuardarAvion.Name = "btnGuardarAvion";
            btnGuardarAvion.Size = new Size(99, 23);
            btnGuardarAvion.TabIndex = 0;
            btnGuardarAvion.Text = "Guardar Avion";
            btnGuardarAvion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAvion
            // 
            btnEliminarAvion.Location = new Point(18, 257);
            btnEliminarAvion.Name = "btnEliminarAvion";
            btnEliminarAvion.Size = new Size(99, 23);
            btnEliminarAvion.TabIndex = 1;
            btnEliminarAvion.Text = "Eliminar Avion";
            btnEliminarAvion.UseVisualStyleBackColor = true;
            // 
            // btnProgramarVuelo
            // 
            btnProgramarVuelo.Location = new Point(140, 257);
            btnProgramarVuelo.Name = "btnProgramarVuelo";
            btnProgramarVuelo.Size = new Size(110, 23);
            btnProgramarVuelo.TabIndex = 2;
            btnProgramarVuelo.Text = "Programar Vuelo";
            btnProgramarVuelo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(325, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(150, 116);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnGuardarAvion);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 285);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(80, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 2);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "REGISTRAR AVIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 93);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 151);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Capacidad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Modelo";
            // 
            // dgvAviones
            // 
            dgvAviones.BackgroundColor = SystemColors.ActiveCaption;
            dgvAviones.BorderStyle = BorderStyle.Fixed3D;
            dgvAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAviones.Location = new Point(18, 15);
            dgvAviones.Name = "dgvAviones";
            dgvAviones.Size = new Size(289, 217);
            dgvAviones.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, -1);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 6;
            label4.Text = "muestra la informacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 2);
            label5.Name = "label5";
            label5.Size = new Size(159, 15);
            label5.TabIndex = 7;
            label5.Text = "muestra imagen del modelo ";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dgvAviones);
            panel2.Controls.Add(btnEliminarAvion);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(btnProgramarVuelo);
            panel2.Location = new Point(258, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 285);
            panel2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 27);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 7;
            label6.Text = "icono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 305);
            label7.Name = "label7";
            label7.Size = new Size(412, 15);
            label7.TabIndex = 9;
            label7.Text = "lo de agregar ususario podria ir en otro formulario que este conectado a este ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnGuardarUsuario);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(221, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 277);
            panel3.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 14);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 0;
            label8.Text = "Nombre Completo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 58);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 1;
            label9.Text = "Edad";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "Sexo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 112);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 3;
            label10.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(157, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 92);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(123, 235);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(75, 23);
            btnGuardarUsuario.TabIndex = 8;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 662);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAviones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarAvion;
        private Button btnEliminarAvion;
        private Button btnProgramarVuelo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridView dgvAviones;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label10;
        private ComboBox comboBox2;
        private Label label9;
        private Label label8;
        private Button btnGuardarUsuario;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
