using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using Biblioteca_de_Clases;
using Biblioteca_de_Controles;
using MongoDB.Driver;

namespace Aero_Formularios
{
    public partial class FRM_Mapa_de_Mexico : Form
    {
        /*############################### Base de Datos (BD) #############################
         * ###############################################################################*/

        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<DatosDelVuelo> Vuelos_datos;

        /*########################### Variables e Inicilizaicones #########################
         * ###############################################################################*/

        Contenedor contenedor;
        Lista_Coordenadas Lista_Coordenadas;
        Thread hilo_Vuelo;

        public FRM_Mapa_de_Mexico()
        {
            InitializeComponent();

            Lista_Coordenadas = new Lista_Coordenadas();
            contenedor = Lista_Coordenadas.getLista();

            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("Aeropuerto");
            Vuelos_datos = db.GetCollection<DatosDelVuelo>("Vuelos");
            IniciarVuelos();
            mostarControles();

        }

        /*################################### Metodos #################################
         ###############################################################################*/

        private void IniciarVuelos()
        {
            List<DatosDelVuelo> vuelos = Vuelos_datos.Find(v => v.Status == "En espera...").ToList();
            foreach (DatosDelVuelo v in vuelos)
            {
                List<Coordenada> coordenadas = EstablecerCoordenadas(v);

                Coordenada inicio = coordenadas[0];
                Coordenada fin = coordenadas[1];

                Vuelo vuelo = new Vuelo(PbMapaDeMexico, inicio, fin);
                
                v.Status = "Vuelo Completado";
                Vuelos_datos.ReplaceOne(vu => vu.Id == v.Id, v);
            }
        }

        private List<Coordenada> EstablecerCoordenadas(DatosDelVuelo v)
        {

            List<Coordenada> lista = new List<Coordenada>();
            lista.Clear();

            //####################### Inicial #######################3
            if (v.AeropuertoSalida == "Tijuana")
            {
                Coordenada c = contenedor.getCoordenada(0);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Chihuahua")
            {
                Coordenada c = contenedor.getCoordenada(1);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Monterrey")
            {
                Coordenada c = contenedor.getCoordenada(2);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Guadalajara")
            {
                Coordenada c = contenedor.getCoordenada(3);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Ciudad de Mexico")
            {
                Coordenada c = contenedor.getCoordenada(4);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Puebla")
            {
                Coordenada c = contenedor.getCoordenada(5);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Acapulco")
            {
                Coordenada c = contenedor.getCoordenada(6);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Merida")
            {
                Coordenada c = contenedor.getCoordenada(7);
                lista.Add(c);
            }
            else if (v.AeropuertoSalida == "Cancún")
            {
                Coordenada c = contenedor.getCoordenada(8);
                lista.Add(c);
            }

            //###################### Final #########################
            if (v.AeropuertoDestino == "Tijuana")
            {
                Coordenada c1 = contenedor.getCoordenada(0);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Chihuahua")
            {
                Coordenada c1 = contenedor.getCoordenada(1);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Monterrey")
            {
                Coordenada c1 = contenedor.getCoordenada(2);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Guadalajara")
            {
                Coordenada c1 = contenedor.getCoordenada(3);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Ciudad de Mexico")
            {
                Coordenada c1 = contenedor.getCoordenada(4);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Puebla")
            {
                Coordenada c1 = contenedor.getCoordenada(5);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Acapulco")
            {
                Coordenada c1 = contenedor.getCoordenada(6);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Merida")
            {
                Coordenada c1 = contenedor.getCoordenada(7);
                lista.Add(c1);
            }
            else if (v.AeropuertoDestino == "Cancún")
            {
                Coordenada c1 = contenedor.getCoordenada(8);
                lista.Add(c1);
            }

            return lista;
        }

        public void mostarControles()
        {
            
            List<DatosDelVuelo> Lista = Vuelos_datos.Find(p => true).ToList();
            foreach (DatosDelVuelo d in Lista)
            {
                ucDatosVuelo ControlesVuelo = new ucDatosVuelo();
                ControlesVuelo.datosDelVuelo = d;
                ControlesVuelo.Informacion();
             FlwContenedorControles.Controls.Add(ControlesVuelo);
            }
           

        }

    }
}
