﻿using Aero_Formularios.Properties;
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
            Cronometro.Start();
        }

        //este es el metodo que guardara los datos del vuelo
        //esta listo para dos tipos de errores del poner mismo delugar de salida y destino y no elegir modelo de avión
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbModeloAvion.Text == "Modelo")
                {
                    MessageBox.Show("No hay selección de modelo  del avión");
                }
                else
                {
                    if (CmbAeropuertoSalida.Text != CmbAeropuertoDestino.Text)
                    {
                        DatosDelVuelo Datos = new DatosDelVuelo();
                        txtPasajeros.Text.ToLower();
                        txtPasajeros.Text.Replace("a,b,c,d,e,f,g,h,i,j,k,l,m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z,°," +
                            "!,;,#,$,%,&,/,(,=,),?,¡,¿,+,*,-,@","");
                        Datos.Capitan = lblNombrePiloto.Text;
                        Datos.Modelo = CmbModeloAvion.Text;
                        Datos.Pasajeros = Convert.ToInt32(txtPasajeros.Text);
                        Datos.AeropuertoSalida = CmbAeropuertoSalida.Text;
                        Datos.AeropuertoDestino = CmbAeropuertoDestino.Text;
                        Vuelos_datos.InsertOne(Datos);
                    }
                    else
                    {
                        MessageBox.Show("No puedes agregar un vuelo al mismo sitio donde te encuentras ");
                    }
                }
            }
            catch (Exception)
            {
                    throw;
            }

        }

        public void AsignacionCapitan()
        {
            int numero;
            Random rand = new Random();
            numero = (int)rand.Next(0, 9);
            switch (numero)
            {
                case 1:
                    pbPiloto.Image = Image.FromFile("");
                    lblNombrePiloto.Text = " Anet Cadena ";
                    break;
                case 2:
                    pbPiloto.Image =
                    lblNombrePiloto.Text = "Hadri de Jesús";
                    break;
                case 3:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Jafeth Perez";
                    break;
                case 4:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Jesus Bibiano";
                    break;
                case 5:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Jose Luis";
                    break;
                case 6:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Juan Manuel";
                    break;
                case 7:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Lazaro Bibiano";
                    break;
                case 8:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Jack Harris";
                    break;
                case 9:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Vazili Zitzep";
                    break;
                case 0:
                    pbPiloto.Image = Image.FromFile();
                    lblNombrePiloto.Text = "Wilson Zalazar";
                    break;
            }
        }
        
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            string MODELO = CmbModeloAvion.Text;
            switch (MODELO)
            {
                case "Boeing 737":
                    PBVisualizacion.Image = Properties.Resources.Boeing_737;
                    break;
                case "Airbus A320":
                    PBVisualizacion.Image =Properties.Resources.Airbus_A320;
                    break;
                case "Embraer E-jet":
                    PBVisualizacion.Image = Properties.Resources.Embraer_E_Jet;
                    break;
                case "Bombardier CRJ":
                    PBVisualizacion.Image = Properties.Resources.Bombardier_CRJ;
                    break;
                case "Boeing 787":
                    PBVisualizacion.Image = Properties.Resources.Boeing_787_Dreamliner;
                    break;
                case "Boeing 777":
                    PBVisualizacion.Image = Properties.Resources.Boeing_777;
                    break;

            }
        }
    }
}

