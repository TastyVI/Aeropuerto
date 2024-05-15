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
        List<Usuario> Usuario;
        string Id_Usuario;
        string Id_mongo;


        public FRM_Usuarios()
        {
            InitializeComponent();
            cliente = new MongoClient("mongodb://localhost:27017");
            db = db.Client.GetDatabase("Aereopuerto");
            Usuario_alta = db.GetCollection<Usuario>("Usuarios");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu= new Usuario();


        }
        private string GenerarID()// genera un ID aleatorio
        {
            string cadena = "jfhkjfsdbhfbshdbhsjbkj";
            Random r = new Random();
            string res = "";
            for (int i = 0; i < 5; i++)
            {
                int numeroAleatorio = r.Next(0, cadena.Length - 1);
                res += cadena[numeroAleatorio];
            }
            return res;

        }
    }
}
