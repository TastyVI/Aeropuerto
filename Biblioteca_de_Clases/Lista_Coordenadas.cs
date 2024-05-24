using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Lista_Coordenadas
    {
        /*########################### Variables e Inicilizaicones #########################
         * ###############################################################################*/
        //HOla que hace

        Contenedor Contenedor;
        
        public Lista_Coordenadas()
        {
            Contenedor = new Contenedor();

            Coordenada Tijuana = new Coordenada();
            Tijuana.Valor_X = 50;
            Tijuana.Valor_Y = 23;
            Contenedor.Agregar(Tijuana);

            Coordenada Chihuahua = new Coordenada();
            Chihuahua.Valor_X = 288;
            Chihuahua.Valor_Y = 116;
            Contenedor.Agregar(Chihuahua);

            Coordenada Monterrey = new Coordenada();
            Monterrey.Valor_X = 438;
            Monterrey.Valor_Y = 174;
            Contenedor.Agregar(Monterrey);

            Coordenada Guadalajara = new Coordenada();
            Guadalajara.Valor_X = 359;
            Guadalajara.Valor_Y = 290;
            Contenedor.Agregar(Guadalajara);

            Coordenada CDMX = new Coordenada();
            CDMX.Valor_X = 463;
            CDMX.Valor_Y = 326;
            Contenedor.Agregar(CDMX);

            Coordenada Puebla = new Coordenada();
            Puebla.Valor_X = 488;
            Puebla.Valor_Y = 326;
            Contenedor.Agregar(Puebla);

            Coordenada Acapulco = new Coordenada();
            Acapulco.Valor_X = 438;
            Acapulco.Valor_Y = 366;
            Contenedor.Agregar(Acapulco);

            Coordenada Merida = new Coordenada();
            Merida.Valor_X = 694;
            Merida.Valor_Y = 284;
            Contenedor.Agregar(Merida);

            Coordenada Cancun = new Coordenada();
            Cancun.Valor_X = 758;
            Cancun.Valor_Y = 284;
            Contenedor.Agregar(Cancun);
        }

        /*################################### Metodos #################################
       * ###############################################################################*/

        public Contenedor getLista()
        {
            return Contenedor;
        }
    }
}
