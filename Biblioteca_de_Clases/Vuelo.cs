using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Biblioteca_de_Clases
{
    public class Vuelo
    {
        /*########################### Variables e Inicilizaicones #########################
         * ###############################################################################*/
        public PictureBox PB_Avion { get; private set; }

        private bool vuelo;
        private int coordenada_Inicial_X;
        private int coordenada_Inicial_Y;
        private int coordenada_Final_X;
        private int coordenada_Final_Y;
        private Thread hilo_Vuelo;
        private PictureBox form;

        /*################################### Delegados #################################
         ###############################################################################*/

        private delegate void delegado_Movimiento(int x, int y, PictureBox p);
        private void metodo_Movimiento(int x, int y, PictureBox p)
        {
            if (form.InvokeRequired)
            {
                delegado_Movimiento dm = new delegado_Movimiento(metodo_Movimiento);
                object[] m = { x, y, p };
                form.Invoke(dm, m);
            }
            else
            {
                p.Location = new Point(x, y);
            }
        }

        /*################################### Metodos #################################
         ###############################################################################*/
        public Vuelo(PictureBox frm, Coordenada inicio, Coordenada fin)
        {
            form = frm;

            vuelo = true;

            coordenada_Inicial_X = inicio.Valor_X;
            coordenada_Inicial_Y = inicio.Valor_Y;
            coordenada_Final_X = fin.Valor_X;
            coordenada_Final_Y = fin.Valor_Y;

            PB_Avion = new PictureBox();
            PB_Avion.Location = new Point(coordenada_Inicial_Y, coordenada_Inicial_X);
            PB_Avion.Size = new Size(5, 5);
            PB_Avion.BackColor = Color.Black;
            PB_Avion.Click += PB_Click;
            form.Controls.Add(PB_Avion);

            hilo_Vuelo = new Thread(MoverAvion);
            hilo_Vuelo.IsBackground = true; 
            hilo_Vuelo.Start();
        }

        private void MoverAvion()
        {
            Point final = new Point(coordenada_Final_X, coordenada_Final_Y);
            int x = coordenada_Inicial_X;
            int y = coordenada_Inicial_Y;

            while (PB_Avion.Location != final && vuelo)
            {
                if (x < final.X) x++;
                else if (x > final.X) x--;

                if (y < final.Y) y++;
                else if (y > final.Y) y--;

                metodo_Movimiento(x, y, PB_Avion);
                Thread.Sleep(100); 
            }
            vuelo = false;
        }

        /*################################### Eventos #################################
         ###############################################################################*/
        private void PB_Click(object sender, EventArgs e)
        {
           
        }
    }
}
