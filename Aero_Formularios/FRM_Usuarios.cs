using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using Biblioteca_de_Clases;


namespace Aero_Formularios
{
    public partial class FRM_Usuarios : Form
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<Usuario> Usuario_alta;
        List<Usuario> Usuarios;
        string Id_Usuario;
        string Id_mongo;


        public FRM_Usuarios()
        {
            InitializeComponent();
            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("Aeropuerto");
            Usuario_alta = db.GetCollection<Usuario>("Usuarios");
            consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.IdUsuario = GenerarID();
            usu.Contrasena = txtContrasena.Text;
            usu.Nombre = txtNombre.Text;
            usu.N_Usuario = txtUsuario.Text;
            usu.Administrador = chbTipo.Checked;
            Usuario_alta.InsertOne(usu);
            consultar();
            limpiar();


        }
        private string GenerarID()// genera un ID aleatorio
        {
            string cadena = "0123456789";
            Random r = new Random();
            string res = "";
            for (int i = 0; i < 5; i++)
            {
                int numeroAleatorio = r.Next(0, cadena.Length - 1);
                res += cadena[numeroAleatorio];
            }
            return res;

        }
        private void consultar()
        {
            List<Usuario> lista = Usuario_alta.Find(p => true).ToList();
            //List<dynamic> mostrar = new List<dynamic>();
            //foreach (Usuario p in lista)
            //{
            //    string Nombre, Usuario, Contraseña;
            //    string Administrador;
            //    Nombre = p.Nombre;
            //    Usuario = p.N_Usuario;
            //    Contraseña = p.Contrasena;
            //    Administrador = p.Administrador.ToString();
            //    mostrar.Add(new { Nombre, Usuario, Contraseña, Administrador });
            //}
            dgvDatos.DataSource = lista;
        }
        private void limpiar()
        {
            txtContrasena.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            chbTipo.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvDatos_Click(object sender, EventArgs e)
        {
            string comprobar;
            string oid = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();// en la matriz localiza la posicion del numero de control en este caso, y permite seleccionarlo 
            //Buscar ID en la base de datos
            Usuario usu = Usuario_alta.Find(usu => usu.IdUsuario == oid).FirstOrDefault();
            // en el lugar de paquete va 
            //el nombre en el servidor mongo
            if (usu != null)
            {

                comprobar = usu.Administrador.ToString();
                txtContrasena.Text = usu.Contrasena;
                txtNombre.Text = usu.Nombre;
                txtUsuario.Text = usu.N_Usuario;
                chbTipo.Checked = bool.Parse(comprobar);
                // al seleccionar los botones anteriores se habilitan
                Id_Usuario = usu.IdUsuario;
                Id_mongo = usu.Id;


            }
            else
            {
                MessageBox.Show("Paquete no encontrado");
            }
        }

    }
}
