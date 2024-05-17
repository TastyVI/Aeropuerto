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
            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("Aereopuerto");
            Vuelos_datos = db.GetCollection<DatosDelVuelo>("Vuelos");
            AsignacionCapitan();
            MostrarModelo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosDelVuelo Datos = new DatosDelVuelo();
            Datos.Capitan = lblNombrePiloto.Text;
            Datos.Modelo = CmbModeloAvion.Text;
            Datos.Pasajeros = Convert.ToInt32(txtPasajeros.Text);
            Datos.AeropuertoSalida = CmbAeropuertoSalida.Text;
            Datos.AeropuertoDestino = CmbAeropuertoDestino.Text;
            Vuelos_datos.InsertOne(Datos);




        }

        public void AsignacionCapitan()

        {
            int numero;
            Random rand = new Random();
            numero = (int)rand.Next(0, 9);
            switch (numero)
            {
                case 1:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP ANET CADENA.jpg");
                    lblNombrePiloto.Text = " Anet Cadena ";
                    break;
                case 2:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Capitanes\\CAP HADRI DE LOPEZ.jpg");
                    lblNombrePiloto.Text = "Hadri de Jesús";
                    break;
                case 3:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Capitanes\\CAP JAFEHT PEREZ.jpg");
                    lblNombrePiloto.Text = "Jafeth Perez";
                    break;
                case 4:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Capitanes\\CAP JESUS BIBIANO.jpg");
                    lblNombrePiloto.Text = "Jesus Bibiano";
                    break;
                case 5:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP JOSE LUIS.jpg");
                    lblNombrePiloto.Text = "Jose Luis";
                    break;
                case 6:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP JUAN MANUEL.jpg");
                    lblNombrePiloto.Text = "Juan Manuel";
                    break;
                case 7:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP LAZARO BIBIANO.jpg");
                    lblNombrePiloto.Text = "Lazaro Bibiano";
                    break;
                case 8:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP JACK HARRIS.jpg");
                    lblNombrePiloto.Text = "Jack Harris";
                    break;
                case 9:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP VAZILI ZITZEP.jpg");
                    lblNombrePiloto.Text = "Vazili Zitzep";
                    break;
                case 0:
                    pbPiloto.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Capitanes\\CAP WILSON  ZALAZAR.jpg");
                    lblNombrePiloto.Text = "Wilson Zalazar";
                    break;

            }
        }
        public void MostrarModelo()
        {
            Cronometro.Start();
            string MODELO = CmbModeloAvion.Text;
            switch (MODELO)
            {
                case "Boeing 737":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Boeing 737.jpeg");
                    break;
                case "Airbus A320":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Airbus A320.jpeg");
                    break;
                case "Embraer E-jet":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Embraer E-Jet.jpeg");
                    break;
                case "Bombardier CRJ":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Bombardier CRJ.jpeg");
                    break;
                case "Boeing 787":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Boeing 787 Dreamliner.jpeg");
                    break;
                case "Boeing 777":
                    PBVisualizacion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Boeing 777.jpeg");
                    break;

            }
        }

        private void CmbModeloAvion_Click(object sender, EventArgs e)
        {


        }
    }
}

