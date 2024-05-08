namespace Aero_Formularios
{
    partial class Mapa_de_Mexico
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
            PbMapaDeMexico = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbMapaDeMexico).BeginInit();
            SuspendLayout();
            // 
            // PbMapaDeMexico
            // 
            PbMapaDeMexico.Image = Properties.Resources.MAPA_DE_MEXICO;
            PbMapaDeMexico.Location = new Point(2, -1);
            PbMapaDeMexico.Name = "PbMapaDeMexico";
            PbMapaDeMexico.Size = new Size(872, 573);
            PbMapaDeMexico.SizeMode = PictureBoxSizeMode.StretchImage;
            PbMapaDeMexico.TabIndex = 0;
            PbMapaDeMexico.TabStop = false;
            // 
            // Mapa_de_Mexico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 592);
            Controls.Add(PbMapaDeMexico);
            Name = "Mapa_de_Mexico";
            Text = "Mapa_de_Mexico";
            ((System.ComponentModel.ISupportInitialize)PbMapaDeMexico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PbMapaDeMexico;
    }
}