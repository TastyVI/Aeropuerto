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
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 48);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 11.25F);
            button1.Location = new Point(66, 235);
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
            label2.Location = new Point(66, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(144, 149);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(110, 23);
            txtContrasena.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(43, 149);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 11.25F);
            button2.Location = new Point(171, 235);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 8;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(141, 104);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(110, 23);
            txtUsuario.TabIndex = 9;
            // 
            // chbTipo
            // 
            chbTipo.AutoSize = true;
            chbTipo.Font = new Font("Century Gothic", 11.25F);
            chbTipo.Location = new Point(86, 190);
            chbTipo.Margin = new Padding(3, 2, 3, 2);
            chbTipo.Name = "chbTipo";
            chbTipo.Size = new Size(128, 24);
            chbTipo.TabIndex = 10;
            chbTipo.Text = "Administrador";
            chbTipo.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(296, 23);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(500, 336);
            dgvDatos.TabIndex = 11;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // FRM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FRM_Usuarios";
            Text = "frmUsuarios";
            Load += FRM_Usuarios_Load;
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