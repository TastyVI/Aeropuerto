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
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(88, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 129);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(164, 199);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 199);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // button2
            // 
            button2.Location = new Point(195, 313);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(161, 138);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 9;
            // 
            // chbTipo
            // 
            chbTipo.AutoSize = true;
            chbTipo.Location = new Point(98, 254);
            chbTipo.Name = "chbTipo";
            chbTipo.Size = new Size(126, 24);
            chbTipo.TabIndex = 10;
            chbTipo.Text = "Administrador";
            chbTipo.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(338, 31);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(571, 448);
            dgvDatos.TabIndex = 11;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // FRM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvDatos);
            Controls.Add(chbTipo);
            Controls.Add(txtUsuario);
            Controls.Add(button2);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRM_Usuarios";
            Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}