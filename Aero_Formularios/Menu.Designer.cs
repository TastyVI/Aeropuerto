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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelMenu = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            BarraTitulo = new Panel();
            lblTituloFormularioHijo = new Label();
            iconoFormularioHijo = new FontAwesome.Sharp.IconPictureBox();
            panelFormularios = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFormularioHijo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 51, 102);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 562);
            panelMenu.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = SystemColors.ButtonFace;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton2.IconColor = Color.Silver;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 198);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(190, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "USUARIOS";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plane;
            iconButton1.IconColor = Color.Silver;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 138);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(190, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "AVIONES";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
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
            BarraTitulo.Controls.Add(lblTituloFormularioHijo);
            BarraTitulo.Controls.Add(iconoFormularioHijo);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(190, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(597, 55);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblTituloFormularioHijo
            // 
            lblTituloFormularioHijo.AutoSize = true;
            lblTituloFormularioHijo.ForeColor = Color.DarkGray;
            lblTituloFormularioHijo.Location = new Point(68, 19);
            lblTituloFormularioHijo.Name = "lblTituloFormularioHijo";
            lblTituloFormularioHijo.Size = new Size(36, 15);
            lblTituloFormularioHijo.TabIndex = 1;
            lblTituloFormularioHijo.Text = "Inicio";
            // 
            // iconoFormularioHijo
            // 
            iconoFormularioHijo.BackColor = Color.FromArgb(0, 51, 102);
            iconoFormularioHijo.ForeColor = Color.DarkGray;
            iconoFormularioHijo.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconoFormularioHijo.IconColor = Color.DarkGray;
            iconoFormularioHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoFormularioHijo.Location = new Point(26, 12);
            iconoFormularioHijo.Name = "iconoFormularioHijo";
            iconoFormularioHijo.Size = new Size(32, 32);
            iconoFormularioHijo.TabIndex = 0;
            iconoFormularioHijo.TabStop = false;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.FromArgb(96, 125, 139);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(190, 55);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(597, 507);
            panelFormularios.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 562);
            Controls.Add(panelFormularios);
            Controls.Add(BarraTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFormularioHijo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox btnInicio;
        private Panel BarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijo;
        private Label lblTituloFormularioHijo;
        private Panel panelFormularios;
    }
}
