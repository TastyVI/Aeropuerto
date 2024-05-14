using Biblioteca_de_Clases;
namespace Biblioteca_de_Controles
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void asignacion()
        {
            DatosDelVuelo datos = new DatosDelVuelo();
            LblAeropuertoAterrizaje.Text = datos.AeropuertoDestino;
            LblAeropuertoDespegue.Text = datos.AeropuertoSalida;
            LblModeloAvion.Text = datos.ModeloAvion;
            LblNombreCapitan.Text = datos.NombreCapitan;
            LblNumerodePasajeros.Text = datos.PasajerosAbordo.ToString();
        }
    }
}
