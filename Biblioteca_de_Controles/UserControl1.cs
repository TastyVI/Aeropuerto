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
            LblModeloAvion.Text = datos.Modelo;
            string MODELO = LblModeloAvion.Text;
            switch (MODELO)
            {
                case "Boeing 737":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Boeing 737.jpeg");
                    break;
                case "Airbus A320":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Airbus A320.jpeg");
                    break;
                case "Embraer E-jet":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Embraer E-Jet.jpeg");
                    break;
                case "Bombardier CRJ":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Bombardier CRJ.jpeg");
                    break;
                case "Boeing 787":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\Aeropuerto\\" +
                        "Aero_Formularios\\Resources\\Boeing 787 Dreamliner.jpeg");
                    break;
                case "Boeing 777":
                    PbModeloAvion.Image = Image.FromFile("C:\\Users\\carlo\\Source\\Repos\\TastyVI\\" +
                        "Aeropuerto\\Aero_Formularios\\Resources\\Boeing 777.jpeg");
                    break;

            }

            LblAeropuertoAterrizaje.Text = datos.AeropuertoDestino;
            LblAeropuertoDespegue.Text = datos.AeropuertoSalida;
            LblNombreCapitan.Text = datos.Capitan;
            LblNumerodePasajeros.Text = datos.Pasajeros.ToString();





        }
    }
}
