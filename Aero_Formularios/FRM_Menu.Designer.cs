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
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            BarraTitulo = new Panel();
            lblTituloFormularioHijo = new Label();
            panelFormularios = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 51, 102);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 545);
            panelMenu.TabIndex = 0;
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
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(190, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1004, 55);
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
            ResumeLayout(false);
            PerformLayout();
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
