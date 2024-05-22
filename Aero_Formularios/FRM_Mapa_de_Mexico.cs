using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Clases;

namespace Aero_Formularios
{
    public partial class FRM_Mapa_de_Mexico : Form
    {
        /*########################### Variables e Inicilizaicones #########################
         * ###############################################################################*/

        Contenedor contenedor;
        Lista_Coordenadas Lista_Coordenadas;
        PictureBox PB_Avion;

        int coordenada_Inicial_X;
        int coordenada_Inicial_Y;

        int coordenada_Final_X;
        int coordenada_Final_Y;

        Thread hilo_Vuelo;
        
        public FRM_Mapa_de_Mexico()
        {
            InitializeComponent();
            PB_Avion = new PictureBox();
            Lista_Coordenadas = new Lista_Coordenadas();
            contenedor = Lista_Coordenadas.getLista();
            coordenada_Inicial_X = 50;
            coordenada_Inicial_Y = 50;
            coordenada_Final_X = 300;    
            coordenada_Final_Y = 300;

            hilo_Vuelo = new Thread(Vuelo);
            hilo_Vuelo.Start();
        }

        /*######################### Delegados y sus metodos #############################
        * ###############################################################################*/

        private delegate void delegado_Movimiento(int x, int y);

        private void metodo_Movimiento(int x, int y)
        {
            
            if (InvokeRequired)
            {
                delegado_Movimiento dm = new delegado_Movimiento(metodo_Movimiento);
                object[] m = { x, y };          
                Invoke(dm,m);
            }
            else
            {
                PB_Avion.Location = new Point(x, y);
            }
        }


        /*################################### Metodos #################################
       * ###############################################################################*/

        private void Vuelo()
        {
            PB_Avion.Location = new Point(coordenada_Inicial_X, coordenada_Inicial_Y);
            PB_Avion.Size = new Size(30,30);    
            PB_Avion.BackColor = Color.Red;
            PbMapaDeMexico.Controls.Add(PB_Avion);
            int x = PB_Avion.Location.X;
            int y = PB_Avion.Location.Y;
            Point final = new Point(coordenada_Final_X, coordenada_Final_Y);

            //Controls.Add(PB_Avion);
            while (PB_Avion.Location != final)
            {
                if (x < final.X)
                    x++;
                else if (x > final.X)
                    x--;

                if (y < final.Y)
                    y++;
                else if (y > final.Y)
                    y--;

                metodo_Movimiento(x,y);
                Thread.Sleep(100);
            }

        }

    }
}
