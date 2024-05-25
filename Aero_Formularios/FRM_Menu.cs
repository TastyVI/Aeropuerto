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
        private Form formularioHijoActual;
        private List<Form> formulariosHijos;

        public FRM_Menu()
        {
            InitializeComponent();
            panelIzquierdo = new Panel();
            panelIzquierdo.Size = new Size(8, 44);
            panelMenu.Controls.Add(panelIzquierdo);
            formulariosHijos = new List<Form>();

        }
        //estructura
        private struct RGBColores
        {
            public static Color color1 = Color.FromArgb(235, 230, 234);
            public static Color color2 = Color.FromArgb(65, 104, 100);
            public static Color color3 = Color.FromArgb(160, 198, 206);


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
        public void AbrirFormularioHijo(Form nuevoFormularioHijo)
        {
            if (FormularioHijo != null)
            {
                FormularioHijo.Hide();
            }
            FormularioHijo = nuevoFormularioHijo;

            if (!formulariosHijos.Contains(nuevoFormularioHijo))
            {
                nuevoFormularioHijo.TopLevel = false;
                nuevoFormularioHijo.FormBorderStyle = FormBorderStyle.None;
                nuevoFormularioHijo.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(nuevoFormularioHijo);
                panelFormularios.Tag = nuevoFormularioHijo;
                formulariosHijos.Add(nuevoFormularioHijo);
            }
            nuevoFormularioHijo.BringToFront();
            nuevoFormularioHijo.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activarBoton(sender, RGBColores.color1);
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
            if (FormularioHijo != null)
            {
                FormularioHijo.Close();
                FormularioHijo = null;
            }
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

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            
        }

        private void horaFecha_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
