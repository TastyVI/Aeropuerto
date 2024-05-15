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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(217, 727);
            panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.RightToLeft = RightToLeft.Yes;
            panelLogo.Size = new Size(217, 184);
            panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(-7, 0);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(224, 184);
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
            BarraTitulo.Location = new Point(217, 0);
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1148, 73);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblTituloFormularioHijo
            // 
            lblTituloFormularioHijo.AutoSize = true;
            lblTituloFormularioHijo.ForeColor = Color.DarkGray;
            lblTituloFormularioHijo.Location = new Point(78, 25);
            lblTituloFormularioHijo.Name = "lblTituloFormularioHijo";
            lblTituloFormularioHijo.Size = new Size(45, 20);
            lblTituloFormularioHijo.TabIndex = 1;
            lblTituloFormularioHijo.Text = "Inicio";
            // 
            // panelFormularios
            // 
            panelFormularios.AutoSize = true;
            panelFormularios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFormularios.BackColor = Color.FromArgb(96, 125, 139);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(217, 73);
            panelFormularios.Margin = new Padding(3, 4, 3, 4);
            panelFormularios.MaximumSize = new Size(1146, 649);
            panelFormularios.MinimumSize = new Size(1146, 649);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1146, 649);
            panelFormularios.TabIndex = 2;
            // 
            // FRM_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 727);
            Controls.Add(panelFormularios);
            Controls.Add(BarraTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1380, 763);
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
