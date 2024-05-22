using FontAwesome.Sharp;
using System.Runtime.InteropServices;
namespace Aero_Formularios
{
    public partial class FRM_Menu : Form
    {
        //campos privados de los botones
        private IconButton currentBtn;
        private Panel panelIzquierdo;
        private Form FormularioHijo;

        public FRM_Menu()
        {
            InitializeComponent();
            panelIzquierdo = new Panel();
            panelIzquierdo.Size = new Size(8, 44);
            panelMenu.Controls.Add(panelIzquierdo);


        }
        //estructura
        private struct RGBColores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 221);
            public static Color color6 = Color.FromArgb(249, 88, 155);


        }
        private void activarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarResaltado();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(93, 173, 226);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo
                panelIzquierdo.BackColor = color;
                panelIzquierdo.Location = new Point(0, currentBtn.Location.Y);
                panelIzquierdo.Visible = true;
                panelIzquierdo.BringToFront();
                //icono formulario hijo
                iconoFHijo.IconChar = currentBtn.IconChar;
                iconoFHijo.IconColor = color;

            }

        }

        //desactivar resaltado
        private void DesactivarResaltado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 51, 102);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (FormularioHijo != null)
            {
                FormularioHijo.Close();

            }
            FormularioHijo = formularioHijo;
            //
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            //
            panelFormularios.Controls.Add(formularioHijo);
            panelFormularios.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            //lblTituloFormularioHijo.Text = formularioHijo.Text;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activarBoton(sender, RGBColores.color5);
            AbrirFormularioHijo(new FRM_Usuarios());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            activarBoton(sender, RGBColores.color2);
            AbrirFormularioHijo(new FRM_Agregar_Vuelo());
        }

        private void btnMirar_Click(object sender, EventArgs e)
        {
            activarBoton(sender, RGBColores.color3);
            AbrirFormularioHijo(new FRM_Mapa_de_Mexico());
        }
        

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormularioHijo.Close();
            Reiniciar();
        }

        private void Reiniciar()
        {
            DesactivarResaltado();
            panelIzquierdo.Visible = false;
            iconoFHijo.IconChar = IconChar.Home;
            iconoFHijo.IconColor = Color.DarkGray;
           // lblTituloFormularioHijo.Text = "INICIO";
        }
        //mueve el formulario a traves de ebento del mause
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
    }
}
