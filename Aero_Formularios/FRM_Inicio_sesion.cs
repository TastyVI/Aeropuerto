using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Aero_Formularios
{
    public partial class FRM_Inicio_Sesion : Form
    {
        public FRM_Inicio_Sesion()
        {
           

            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_Inicio_Sesion_Load(object sender, EventArgs e)
        {
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Aeropuerto");
            var collection = database.GetCollection<BsonDocument>("Usuarios");
            string usuario=txtUsuario.Text;
            string contrasena=txtContraseña.Text;
            var filter = Builders<BsonDocument>.Filter.Eq("Nombre", usuario) & Builders<BsonDocument>.Filter.Eq("Contrasena", contrasena);
            var user = collection.Find(filter).FirstOrDefault();

            

            if (user != null)
            {
                this.Hide(); // Esconde el formulario de inicio de sesión
                FRM_Menu fRM_Menu = new FRM_Menu(); // Crea una instancia del nuevo formulario
                fRM_Menu.Show(); // Muestra el nuevo formulario
            }
        
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
