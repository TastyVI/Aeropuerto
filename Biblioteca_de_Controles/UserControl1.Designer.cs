namespace Biblioteca_de_Controles
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PbModeloAvion = new PictureBox();
            LblModeloAvion = new Label();
            ((System.ComponentModel.ISupportInitialize)PbModeloAvion).BeginInit();
            SuspendLayout();
            // 
            // PbModeloAvion
            // 
            PbModeloAvion.BorderStyle = BorderStyle.FixedSingle;
            PbModeloAvion.Location = new Point(16, 13);
            PbModeloAvion.Name = "PbModeloAvion";
            PbModeloAvion.Size = new Size(148, 117);
            PbModeloAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            PbModeloAvion.TabIndex = 0;
            PbModeloAvion.TabStop = false;
            // 
            // LblModeloAvion
            // 
            LblModeloAvion.AutoSize = true;
            LblModeloAvion.BackColor = Color.Transparent;
            LblModeloAvion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblModeloAvion.Location = new Point(16, 142);
            LblModeloAvion.Name = "LblModeloAvion";
            LblModeloAvion.Size = new Size(76, 31);
            LblModeloAvion.TabIndex = 1;
            LblModeloAvion.Text = "label1";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblModeloAvion);
            Controls.Add(PbModeloAvion);
            Name = "UserControl1";
            Size = new Size(498, 257);
            ((System.ComponentModel.ISupportInitialize)PbModeloAvion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbModeloAvion;
        private Label LblModeloAvion;
    }
}
