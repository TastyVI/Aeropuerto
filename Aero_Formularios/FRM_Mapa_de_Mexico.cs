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
        

        public FRM_Mapa_de_Mexico()
        {
            InitializeComponent();
            PB_Avion = new PictureBox();
            Lista_Coordenadas = new Lista_Coordenadas();
            contenedor = Lista_Coordenadas.getLista();

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
                PB_Avion.Location = new Point();
                Invoke(dm,m);

            }
            else
            {
                
            }
        }

        /*################################### Metodos #################################
       * ###############################################################################*/

        

    }
}
