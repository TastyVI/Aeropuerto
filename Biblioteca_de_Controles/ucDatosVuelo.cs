using Biblioteca_de_Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Biblioteca_de_Controles
{
    public partial class ucDatosVuelo : UserControl
    {
        public DatosDelVuelo datosDelVuelo { get; set; }
        public ucDatosVuelo()
        {
            InitializeComponent();
        }
        public void Informacion()
        {
            label2.Text = datosDelVuelo.Id;
            LblAeropuertoAterrizaje.Text = datosDelVuelo.AeropuertoDestino;
            LblAeropuertoDespegue.Text = datosDelVuelo.AeropuertoSalida;
            LblNombreCapitan.Text = datosDelVuelo.Capitan;
            LblNumerodePasajeros.Text = datosDelVuelo.Pasajeros.ToString();
            LblModeloAvion.Text = datosDelVuelo.Modelo;
            string piloto= LblNombreCapitan.Text;
            string modelo = LblModeloAvion.Text;
            switch (piloto)
            {
                case " Anet Cadena ":
                    pbpiloto.Image = Properties.Resources.CAP_ANET_CADENA;
                    break;
                case "Hadri de Jesús":
                    pbpiloto.Image = Properties.Resources.CAP_HADRI_DE_LOPEZ;
                    break;
                case "Jafeth Perez":
                    pbpiloto.Image = Properties.Resources.CAP__AFEHT_PEREZ;
                    break;
                case "Jesus Bibiano":
                    pbpiloto.Image = Properties.Resources.CAP_JESUS_BIBIANO;
                    break;
                case "Jose Luis":
                    pbpiloto.Image = Properties.Resources.CAP_JOSE_LUIS;
                    break;
                case "Juan Manuel":
                    pbpiloto.Image = Properties.Resources.CAP_JUAN_MANUEL;
                    break;
                case "Lazaro Bibiano":
                    pbpiloto.Image = Properties.Resources.CAP_LAZARO_BIBIANO;
                    break;
                case "Jack Harris":
                    pbpiloto.Image = Properties.Resources.CAP_JACK_HARRIS;
                    break;
                case "Vazili Zitzep":
                    pbpiloto.Image = Properties.Resources.CAP_VAZILI_ZITZEP;
                    break;
                case "Wilson Zalazar":
                    pbpiloto.Image = Properties.Resources.CAP_WILSON__ZALAZAR;
                    break;
            }
            switch (modelo)
            {
                case "Boeing 737":
                    PbModeloAvion.Image = Properties.Resources.Boeing_737;
                    break;
                case "Airbus A320":
                    PbModeloAvion.Image = Properties.Resources.Airbus_A320;
                    break;
                case "Embraer E-jet":
                    PbModeloAvion.Image = Properties.Resources.Embraer_E_Jet;
                    break;
                case "Bombardier CRJ":
                    PbModeloAvion.Image = Properties.Resources.Bombardier_CRJ;
                    break;
                case "Boeing 787":
                    PbModeloAvion.Image = Properties.Resources.Boeing_787_Dreamliner;
                    break;
                case "Boeing 777":
                    PbModeloAvion.Image = Properties.Resources.Boeing_777;
                    break;

            }

        }

    }
}

