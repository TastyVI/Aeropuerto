namespace Aero_Formularios
{
    partial class FRM_Usuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNombre = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtContrasena = new TextBox();
            label3 = new Label();
            button2 = new Button();
            txtUsuario = new TextBox();
            chbTipo = new CheckBox();
            dgvDatos = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 154);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 154);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 11.25F);
            button1.Image = Properties.Resources.LogoAvion;
            button1.Location = new Point(102, 370);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 192);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(28, 257);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(218, 23);
            txtContrasena.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 235);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Century Gothic", 11.25F);
            button2.Image = Properties.Resources.LogoAvion;
            button2.Location = new Point(779, 395);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 8;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(97, 193);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(160, 23);
            txtUsuario.TabIndex = 9;
            // 
            // chbTipo
            // 
            chbTipo.AutoSize = true;
            chbTipo.Font = new Font("Century Gothic", 11.25F);
            chbTipo.ForeColor = Color.Black;
            chbTipo.Location = new Point(77, 303);
            chbTipo.Margin = new Padding(3, 2, 3, 2);
            chbTipo.Name = "chbTipo";
            chbTipo.Size = new Size(128, 24);
            chbTipo.TabIndex = 10;
            chbTipo.Text = "Administrador";
            chbTipo.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.LightSlateGray;
            dgvDatos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 51, 102);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.FromArgb(0, 51, 102);
            dgvDatos.Location = new Point(277, 43);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 51, 102);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(698, 296);
            dgvDatos.TabIndex = 11;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(chbTipo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtContrasena);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 448);
            panel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(272, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 448);
            panel3.TabIndex = 14;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SlateGray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 97;
            iconPictureBox1.Location = new Point(97, 24);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(108, 97);
            iconPictureBox1.TabIndex = 11;
            iconPictureBox1.TabStop = false;
            // 
            // FRM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(987, 448);
            Controls.Add(button2);
            Controls.Add(dgvDatos);
            Controls.Add(panel1);
            Name = "FRM_Usuarios";
            Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button button1;
        private TextBox Usuario;
        private Label label2;
        private TextBox txtContrasena;
        private Label label3;
        private Button button2;
        private TextBox txtUsuario;
        private CheckBox chbTipo;
        private DataGridView dgvDatos;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
    }
}