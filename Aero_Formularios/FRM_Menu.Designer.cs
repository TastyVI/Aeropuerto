namespace Aero_Formularios
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            panelMenu = new Panel();
            btnMirar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            BarraTitulo = new Panel();
            iconoFHijo = new FontAwesome.Sharp.IconPictureBox();
            lblTituloFormularioHijo = new Label();
            panelFormularios = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFHijo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 51, 102);
            panelMenu.Controls.Add(btnMirar);
            panelMenu.Controls.Add(btnAgregar);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 545);
            panelMenu.TabIndex = 0;
            // 
            // btnMirar
            // 
            btnMirar.Dock = DockStyle.Top;
            btnMirar.FlatAppearance.BorderSize = 0;
            btnMirar.FlatStyle = FlatStyle.Flat;
            btnMirar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMirar.ForeColor = Color.DarkGray;
            btnMirar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnMirar.IconColor = Color.DarkGray;
            btnMirar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMirar.IconSize = 30;
            btnMirar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMirar.Location = new Point(0, 226);
            btnMirar.Name = "btnMirar";
            btnMirar.Padding = new Padding(10, 0, 20, 0);
            btnMirar.Size = new Size(190, 44);
            btnMirar.TabIndex = 3;
            btnMirar.Text = "MIRAR VUELO";
            btnMirar.TextAlign = ContentAlignment.MiddleLeft;
            btnMirar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMirar.UseVisualStyleBackColor = true;
            btnMirar.Click += btnMirar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Top;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.DarkGray;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregar.IconColor = Color.DarkGray;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(0, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(10, 0, 20, 0);
            btnAgregar.Size = new Size(190, 44);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR VUELO ";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.DarkGray;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuarios.IconColor = Color.DarkGray;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 138);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 20, 0);
            btnUsuarios.Size = new Size(190, 44);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "USUARIOS";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.RightToLeft = RightToLeft.Yes;
            panelLogo.Size = new Size(190, 138);
            panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(-6, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(196, 138);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 51, 102);
            BarraTitulo.Controls.Add(iconoFHijo);
            BarraTitulo.Controls.Add(lblTituloFormularioHijo);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(190, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1004, 55);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // iconoFHijo
            // 
            iconoFHijo.BackColor = Color.FromArgb(0, 51, 102);
            iconoFHijo.ForeColor = Color.DarkGray;
            iconoFHijo.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconoFHijo.IconColor = Color.DarkGray;
            iconoFHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoFHijo.Location = new Point(19, 12);
            iconoFHijo.Name = "iconoFHijo";
            iconoFHijo.Size = new Size(32, 32);
            iconoFHijo.TabIndex = 2;
            iconoFHijo.TabStop = false;
            // 
            // lblTituloFormularioHijo
            // 
            lblTituloFormularioHijo.AutoSize = true;
            lblTituloFormularioHijo.Font = new Font("Century Gothic", 12F);
            lblTituloFormularioHijo.ForeColor = Color.DarkGray;
            lblTituloFormularioHijo.Location = new Point(68, 19);
            lblTituloFormularioHijo.Name = "lblTituloFormularioHijo";
            lblTituloFormularioHijo.Size = new Size(64, 21);
            lblTituloFormularioHijo.TabIndex = 1;
            lblTituloFormularioHijo.Text = "INICIO";
            // 
            // panelFormularios
            // 
            panelFormularios.AutoSize = true;
            panelFormularios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFormularios.BackColor = Color.FromArgb(96, 125, 139);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(190, 55);
            panelFormularios.MaximumSize = new Size(1003, 487);
            panelFormularios.MinimumSize = new Size(1003, 487);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1003, 487);
            panelFormularios.TabIndex = 2;
            // 
            // FRM_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 545);
            Controls.Add(panelFormularios);
            Controls.Add(BarraTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1196, 548);
            Name = "FRM_Menu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFHijo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMirar;
        private PictureBox btnInicio;
        private Panel BarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijo;
        private Label lblTituloFormularioHijo;
        private Panel panelFormularios;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconPictureBox iconoFHijo;
    }
}
