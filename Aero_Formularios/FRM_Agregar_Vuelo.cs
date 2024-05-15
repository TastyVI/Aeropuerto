using Aero_Formularios.Properties;
using Amazon.Auth.AccessControlPolicy;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MongoDB.Driver;
using Biblioteca_de_Clases;
namespace Aero_Formularios
{
    public partial class FRM_Agregar_Vuelo : Form
    {

        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<DatosDelVuelo> Vuelos_datos;
        List<DatosDelVuelo> Vuelos;
        string Id_usuario;
        string Id_mongo;
        public FRM_Agregar_Vuelo()
        {
            InitializeComponent();
     //       PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\Aero_Formularios\\Resources\\Imagen sin icono.jpg");
            cliente= new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("Aereopuerto");
            Vuelos_datos = db.GetCollection<DatosDelVuelo>("Vuelos");

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }
    }
}
