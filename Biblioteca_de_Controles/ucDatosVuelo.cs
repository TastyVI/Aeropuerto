using Biblioteca_de_Clases;
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

            LblAeropuertoAterrizaje.Text = datosDelVuelo.AeropuertoDestino;
            LblAeropuertoDespegue.Text = datosDelVuelo.AeropuertoSalida;
            LblNombreCapitan.Text = datosDelVuelo.Capitan;
            LblNumerodePasajeros.Text = datosDelVuelo.Pasajeros.ToString();
            LblModeloAvion.Text = datosDelVuelo.Modelo;


        }

    }
}

